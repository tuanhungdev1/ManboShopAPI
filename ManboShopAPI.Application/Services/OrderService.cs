using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

public class OrderService : IOrderService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;

	public OrderService(
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILoggerService logger)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
	}

	public async Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(
		OrderRequestParameters parameters)
	{
		try
		{
			var orders = await _unitOfWork.OrderRepository.FetchAllOrderAsync(parameters);
			var orderDtos = _mapper.Map<IEnumerable<OrderDto>>(orders);
			return (orderDtos, orders.MetaData);
		}
		catch (Exception ex)
		{
			_logger.LogError($"Lỗi khi lấy danh sách đơn hàng: {ex.Message}");
			throw;
		}
	}

	public async Task<OrderDto> GetOrderByIdAsync(int orderId)
	{
		var order = await _unitOfWork.OrderRepository
			.FindByCondition(o => o.Id == orderId)
			.Include(o => o.User)
			.Include(o => o.OrderDetails)
				.ThenInclude(od => od.ProductVariantValue)
					.ThenInclude(pv => pv.Product)
						.ThenInclude(p => p.ProductImages)
			.FirstOrDefaultAsync();

		if (order == null)
		{
			_logger.LogError($"Không tìm thấy đơn hàng với Id {orderId}");
			throw new OrderNotFoundException(orderId);
		}

		return _mapper.Map<OrderDto>(order);
	}

	public async Task<OrderDto> CreateOrderAsync(OrderForCreateDto orderForCreateDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			// Validate đầu vào
			if (orderForCreateDto.UserId.HasValue)
			{
				var user = await _unitOfWork.UserRepository.GetByIdAsync(orderForCreateDto.UserId.Value);
				if (user == null)
				{
					throw new UserNotFoundException(orderForCreateDto.UserId.Value);
				}
			}

			var order = _mapper.Map<Order>(orderForCreateDto);

			// Thêm đơn hàng
			await _unitOfWork.OrderRepository.AddAsync(order);
			await _unitOfWork.SaveChangesAsync();

			// Kiểm tra và cập nhật tồn kho
			await ValidateAndUpdateInventory(order);

			await _unitOfWork.CommitAsync();

			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task UpdateOrderStatusAsync(int orderId, OrderStatus newStatus)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository
				.FindByCondition(o => o.Id == orderId)
				.Include(o => o.OrderDetails)
				.FirstOrDefaultAsync();

			if (order == null)
			{
				throw new OrderNotFoundException(orderId);
			}

			// Validate trạng thái
			if (!IsValidStatusTransition(order.Status, newStatus))
			{
				throw new OrderBadRequestException("Trạng thái đơn hàng không hợp lệ");
			}

			order.Status = newStatus;
			order.UpdatedAt = DateTime.UtcNow;

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId)
	{
		var orders = await _unitOfWork.OrderRepository.GetOrdersByUserIdAsync(userId);
		if (!orders.Any())
		{
			_logger.LogWarning($"Không tìm thấy đơn hàng nào của người dùng {userId}");
		}

		return _mapper.Map<IEnumerable<OrderDto>>(orders);
	}

	public async Task CancelOrderAsync(int orderId)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository
				.FindByCondition(o => o.Id == orderId)
				.Include(o => o.OrderDetails)
				.FirstOrDefaultAsync();

			if (order == null)
			{
				throw new OrderNotFoundException(orderId);
			}

			if (!CanCancelOrder(order.Status))
			{
				throw new OrderBadRequestException("Không thể hủy đơn hàng ở trạng thái hiện tại");
			}

			// Hoàn trả số lượng tồn kho
			await RestoreInventory(order);

			order.Status = OrderStatus.Cancelled;
			order.UpdatedAt = DateTime.UtcNow;

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	private async Task ValidateAndUpdateInventory(Order order)
	{
		foreach (var detail in order.OrderDetails)
		{
			var variant = await _unitOfWork.ProductVariantValueRepository
				.GetByIdAsync(detail.ProductVariantValueId);

			if (variant == null)
			{
				throw new ProductNotFoundException("Không tìm thấy loại sản phẩm");
			}

			if (variant.Stock < detail.Quantity)
			{
				throw new OrderBadRequestException($"Sản phẩm {variant.Product.Name} - SKU: {variant.Sku} không đủ số lượng trong kho");
			}

			variant.Stock -= detail.Quantity;
			_unitOfWork.ProductVariantValueRepository.Update(variant);
		}
	}

	private async Task RestoreInventory(Order order)
	{
		foreach (var detail in order.OrderDetails)
		{
			var variant = await _unitOfWork.ProductVariantValueRepository
				.GetByIdAsync(detail.ProductVariantValueId);

			if (variant != null)
			{
				variant.Stock += detail.Quantity;
				_unitOfWork.ProductVariantValueRepository.Update(variant);
			}
		}
	}

	private bool CanCancelOrder(OrderStatus status)
	{
		return status == OrderStatus.Pending || status == OrderStatus.Confirmed || status == OrderStatus.Processing;
	}

	private bool IsValidStatusTransition(OrderStatus currentStatus, OrderStatus newStatus)
	{
		return (currentStatus, newStatus) switch
		{
			(OrderStatus.Pending, OrderStatus.Confirmed) => true,
			(OrderStatus.Pending, OrderStatus.Cancelled) => true,
			(OrderStatus.Confirmed, OrderStatus.Processing) => true,
			(OrderStatus.Confirmed, OrderStatus.Cancelled) => true,
			(OrderStatus.Processing, OrderStatus.Shipped) => true,
			(OrderStatus.Shipped, OrderStatus.Delivered) => true,
			(OrderStatus.Delivered, OrderStatus.Refunded) => true,
			(OrderStatus.Pending, OrderStatus.Failed) => true,
			(OrderStatus.Confirmed, OrderStatus.Failed) => true,
			_ => false
		};
	}

}