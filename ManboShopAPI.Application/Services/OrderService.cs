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
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class OrderService : IOrderService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;
	private readonly UserManager<User> _userManager;

	public OrderService(
		IUnitOfWork unitOfWork,
		UserManager<User> userManager,
		IMapper mapper,
		ILoggerService logger)
	{
		_userManager = userManager;
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
	}
	
	public async Task SoftDeleteOrderAsync(int orderId)
	{
		var order = await _unitOfWork.OrderRepository.GetByIdAsync(orderId);
		if (order == null)
			throw new OrderNotFoundException(orderId);

		// Kiểm tra các điều kiện business logic trước khi xóa
		if (order.Status != OrderStatus.Cancelled && order.Status != OrderStatus.Delivered)
			throw new OrderBadRequestException("Chỉ có thể xóa đơn hàng đã hủy hoặc đã giao hàng");

		await _unitOfWork.OrderRepository.SoftDeleteAsync(order);
		await _unitOfWork.SaveChangesAsync();

		_logger.LogInfo($"Xóa đơn hàng {orderId} thành công");
	}

	public async Task<OrderDto> UpdateShippingStatusAsync(int orderId, OrderStatus status, string? note)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetByIdAsync(orderId);

			if(order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			order.Status = status;

			switch(status)
			{
				case OrderStatus.Confirmed:
					order.ConfirmedAt = DateTime.UtcNow;
					break;
				case OrderStatus.Processing:
					order.ProcessedAt = DateTime.UtcNow;
					break;
				case OrderStatus.Shipped:
					order.ShippedAt = DateTime.UtcNow;
					break;
				case OrderStatus.Delivered:
					order.DeliveredAt = DateTime.UtcNow;
					break;
			}

			if (!string.IsNullOrEmpty(note))
			{
				order.Note = string.IsNullOrEmpty(order.Note)
					? note
					: $"{order.Note} | {note}";
			}

			_unitOfWork.OrderRepository.Update(order);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Cập nhật trạng thái vận chuyển đơn hàng {orderId} thành công");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception ex)
		{
			await _unitOfWork.RollbackAsync();
			_logger.LogError($"Cập nhật trạng thái vận chuyển đơn hàng {orderId} thất bại");
			throw;
		}
	}

	public async Task<OrderDto> UpdatePaymentStatusAsync(int orderId, PaymentStatus status, string? note)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetOrderByIdWithDetailsAsync(orderId);

			if(order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			order.PaymentStatus = status;

			if (!string.IsNullOrEmpty(note))
			{
				order.Note = string.IsNullOrEmpty(order.Note)
					? note
					: $"{order.Note} | {note}";
			}

			_unitOfWork.OrderRepository.Update(order);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Cập nhật trạng thái thanh toán đơn hàng {orderId} thành công");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception ex)
		{
			await _unitOfWork.RollbackAsync();
			_logger.LogError($"Cập nhật trạng thái thanh toán đơn hàng {orderId} thất bại");
			throw;
		}

	}

	public async Task<OrderDto> GetOrderByIdAsync(int orderId)
	{
		var order = await _unitOfWork.OrderRepository.GetOrderByIdWithDetailsAsync(orderId, true);
		if (order == null)
			throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

		return _mapper.Map<OrderDto>(order);
	}

	public async Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId, OrderForUserRequestParameters orderForUserRequestParameters)
	{
		var orders = await _unitOfWork.OrderRepository.GetOrdersByUserIdAsync(userId, orderForUserRequestParameters);
		return _mapper.Map<IEnumerable<OrderDto>>(orders);
	}

	public async Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(OrderRequestParameters parameters)
	{
		var orders = await _unitOfWork.OrderRepository.FetchAllOrderAsync(parameters);
		var orderDtos = _mapper.Map<List<OrderDto>>(orders);
		return (orders: orderDtos, metaData: orders.MetaData);
	}

	public async Task<OrderDto> CreateOrderAsync(OrderForCreateDto orderDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = _mapper.Map<Order>(orderDto);

			// Calculate total
			decimal total = 0;
			foreach (var detail in order.OrderDetails)
			{
				var productVariant = await _unitOfWork.ProductVariantValueRepository
					.GetByIdAsync(detail.ProductVariantValueId);
				detail.Price = productVariant.Price;
				total += detail.Price * detail.Quantity;
			}
			order.Total = total;

			await _unitOfWork.OrderRepository.AddAsync(order);
			await _unitOfWork.SaveChangesAsync();

			// Update product stock
			foreach (var detail in order.OrderDetails)
			{
				var productVariant = await _unitOfWork.ProductVariantValueRepository
					.GetByIdAsync(detail.ProductVariantValueId);
				productVariant.Stock -= detail.Quantity;
				_unitOfWork.ProductVariantValueRepository.Update(productVariant);
			}

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Tạo đơn hàng mới {order.Id} thành công");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<OrderDto> UpdateOrderAsync(int orderId, OrderForUpdateDto orderDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetOrderByIdWithDetailsAsync(orderId);
			if (order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			// Update allowed properties
			order.Note = orderDto.Note;
			order.Status = orderDto.Status;

			_unitOfWork.OrderRepository.Update(order);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Cập nhật đơn hàng {orderId} thành công");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task DeleteOrderAsync(int orderId)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetOrderByIdWithDetailsAsync(orderId);
			if (order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			// Restore product stock
			foreach (var detail in order.OrderDetails)
			{
				var productVariant = await _unitOfWork.ProductVariantValueRepository
					.GetByIdAsync(detail.ProductVariantValueId);
				productVariant.Stock += detail.Quantity;
				_unitOfWork.ProductVariantValueRepository.Update(productVariant);
			}

			_unitOfWork.OrderRepository.Remove(order);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Xóa đơn hàng {orderId} thành công");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<OrderDto> UpdateOrderStatusAsync(int orderId, OrderStatus status)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetByIdAsync(orderId);
			if (order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			await _unitOfWork.OrderRepository.UpdateOrderStatusAsync(orderId, status);
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Cập nhật trạng thái đơn hàng {orderId} thành {status} thành công");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<Dictionary<OrderStatus, int>> GetOrderStatusStatisticsAsync()
	{
		return await _unitOfWork.OrderRepository.GetOrderStatusStatisticsAsync();
	}

	public async Task<decimal> GetTotalRevenueAsync()
	{
		var orders = await _unitOfWork.OrderRepository.FindAll(true).ToListAsync();
		return orders.Sum(o => o.Total);
	}

	public async Task<decimal> GetDailyRevenueAsync(DateTime date)
	{
		return await _unitOfWork.OrderRepository.GetDailyRevenueAsync(date);
	}

	public async Task<IEnumerable<OrderDto>> GetRecentOrdersAsync(int count)
	{
		var orders = await _unitOfWork.OrderRepository.GetRecentOrdersAsync(count, true);
		return _mapper.Map<IEnumerable<OrderDto>>(orders);
	}

	public async Task<IEnumerable<OrderDto>> GetOrdersByDateRangeAsync(
		DateTime startDate,
		DateTime endDate)
	{
		var orders = await _unitOfWork.OrderRepository.GetOrdersByDateRangeAsync(startDate, endDate, true);
		return _mapper.Map<IEnumerable<OrderDto>>(orders);
	}

	public async Task<bool> HasUserPurchasedProductAsync(int userId, int productId)
	{
		return await _unitOfWork.OrderRepository.HasUserPurchasedProductAsync(userId, productId);
	}


	public async Task<OrderDto> CancelOrderAsync(int orderId, int userId , string? cancellationReason)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var order = await _unitOfWork.OrderRepository.GetOrderByIdWithDetailsAsync(orderId);
			if (order == null)
				throw new OrderNotFoundException($"Không tìm thấy đơn hàng {orderId}");

			var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
			var roles = await _userManager.GetRolesAsync(user);
			var isAdmin = roles.Contains("Admin");
			if (user == null)
				throw new UserNotFoundException($"Không tìm thấy người dùng {userId}");
			
			// Kiểm tra quyền hạn
			if (!isAdmin && order.UserId != userId)
			{
				throw new OrderBadRequestException(
					$"Không thể hủy đơn hàng của người khác. " +
					"Chỉ có thể hủy đơn hàng của chính mình hoặc bởi quản trị viên");
			}
			
			// Kiểm tra trạng thái đơn hàng có được phép hủy hay không

			if (!CanCancelOrder(order.Status) && !isAdmin)
			{
				throw new OrderBadRequestException(
					$"Không thể hủy đơn hàng ở trạng thái {order.Status}. " +
					"Chỉ có thể hủy đơn hàng ở trạng thái Pending, Confirmed hoặc Processing");
			}

			// Hoàn lại số lượng tồn kho
			foreach (var detail in order.OrderDetails)
			{
				var productVariant = await _unitOfWork.ProductVariantValueRepository
					.GetByIdAsync(detail.ProductVariantValueId);
				if (productVariant != null)
				{
					productVariant.Stock += detail.Quantity;
					_unitOfWork.ProductVariantValueRepository.Update(productVariant);
				}
			}

			// Cập nhật trạng thái đơn hàng
			order.Status = OrderStatus.Cancelled;
			order.CancelledAt = DateTime.UtcNow;
			order.Note = string.IsNullOrEmpty(order.Note)
				? $"Lý do hủy: {cancellationReason}"
				: $"{order.Note} | Lý do hủy: {cancellationReason}";

			_unitOfWork.OrderRepository.Update(order);
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Hủy đơn hàng {orderId} thành công. Lý do: {cancellationReason}");
			return _mapper.Map<OrderDto>(order);
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			_logger.LogError($"Hủy đơn hàng {orderId} thất bại");
			throw;
		}
	}

	private bool CanCancelOrder(OrderStatus status)
	{
		return status == OrderStatus.Pending ||
			   status == OrderStatus.Confirmed ||
			   status == OrderStatus.Processing;
	}


}