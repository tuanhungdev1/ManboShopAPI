using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class OrderService : IOrderService
	{
		private readonly IOrderRepository _orderRepository;
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public OrderService(IOrderRepository orderRepository,
							IUserRepository userRepository,
							IMapper mapper,
							ILoggerService loggerService)
		{
			_orderRepository = orderRepository;
			_mapper = mapper;
			_logger = loggerService;
			_userRepository = userRepository;
		}

		public async Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(OrderRequestParameters orderRequestParameters)
		{
			var orders = await _orderRepository.FetchAllOrderAsync(orderRequestParameters);
			_logger.LogInfo("Lấy danh sách đơn hàng thành công.");
			var orderDtoList = _mapper.Map<IEnumerable<OrderDto>>(orders);
			return (orderDtoList, metaData: orders.MetaData);
		}

		public async Task<OrderDto> GetOrderByIdAsync(int orderId)
		{
			var order = await _orderRepository
				.FindByCondition(o => o.Id == orderId)
				.Include(o => o.OrderDetails)
				.ThenInclude(od => od.Product)
				.ThenInclude(p => p.ProductImages)
				.FirstOrDefaultAsync()
				;
			if (order == null)
			{
				_logger.LogError($"Không tìm thấy đơn hàng với Id {orderId}");
				throw new OrderNotFoundException(orderId);
			}
			_logger.LogInfo($"Lấy dữ liệu đơn hàng thành công.");
			return _mapper.Map<OrderDto>(order);
		}

		public async Task CreateOrderAsync(OrderForCreateDto orderForCreateDto)
		{
			
			if(orderForCreateDto.UserId == null && orderForCreateDto.SessionId == null)
			{
				_logger.LogError("UserId hoặc SessionId không được để trống");
				throw new OrderBadRequestException("UserId hoặc SessionId không được để trống");
			}

			if(orderForCreateDto.UserId != null & orderForCreateDto.SessionId != null)
			{
				_logger.LogError("Chỉ được chọn một trong hai UserId hoặc SessionId");
				throw new OrderBadRequestException("Chỉ được chọn một trong hai UserId hoặc SessionId");
			}

			if(orderForCreateDto.UserId.HasValue)
			{
				var user = await _userRepository.GetByIdAsync(orderForCreateDto.UserId.Value);

				if(user == null)
				{
					_logger.LogError($"Không tìm thấy người dùng với Id {orderForCreateDto.UserId}");
					throw new UserNotFoundException(orderForCreateDto.UserId.Value);
				}
			}

			if(orderForCreateDto.SessionId != null)
			{
				var isCartExist = await _orderRepository.IsOrderExistingBySessionIdAsync(orderForCreateDto.SessionId);

				if(isCartExist)
				{
					_logger.LogError($"Đơn hàng với SessionId {orderForCreateDto.SessionId} đã tồn tại.");
					throw new OrderBadRequestException($"Đơn hàng với SessionId {orderForCreateDto.SessionId} đã tồn tại.");
				}
			}

			var isValidateStatus = Enum.IsDefined(typeof(OrderStatus), orderForCreateDto.Status);

			if(!isValidateStatus)
			{
				_logger.LogError($"Trạng thái đơn hàng không hợp lệ.");
				throw new OrderBadRequestException("Trạng thái đơn hàng không hợp lệ.");
			}

			var order = _mapper.Map<Order>(orderForCreateDto);
			await _orderRepository.AddAsync(order);
			await _orderRepository.SaveChangesAsync();
			_logger.LogInfo("Tạo đơn hàng mới thành công.");
		}

		public async Task UpdateOrderAsync(int orderId, OrderForUpdateDto orderForUpdateDto)
		{
			var existingOrder = await _orderRepository.GetByIdAsync(orderId);
			if (existingOrder == null)
			{
				_logger.LogError($"Không tìm thấy đơn hàng với Id {orderId}");
				throw new OrderNotFoundException(orderId);
			}

			var user = await _userRepository.GetByIdAsync(orderForUpdateDto.UserId);

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {orderForUpdateDto.UserId}");
				throw new UserNotFoundException(orderForUpdateDto.UserId);
			}

			var isValidateStatus = Enum.IsDefined(typeof(OrderStatus), orderForUpdateDto.Status);

			if (!isValidateStatus)
			{
				_logger.LogError($"Trạng thái đơn hàng không hợp lệ.");
				throw new OrderBadRequestException("Trạng thái đơn hàng không hợp lệ.");
			}

			_mapper.Map(orderForUpdateDto, existingOrder);
			existingOrder.UpdatedAt = DateTime.UtcNow;
			_orderRepository.Update(existingOrder);
			await _orderRepository.SaveChangesAsync();
			_logger.LogInfo($"Cập nhật thành công đơn hàng với Id {existingOrder.Id}");
		}

		public async Task DeleteOrderAsync(int orderId)
		{
			var existingOrder = await _orderRepository.GetByIdAsync(orderId);
			if (existingOrder == null)
			{
				_logger.LogError($"Không tìm thấy đơn hàng với Id {orderId}");
				throw new OrderNotFoundException(orderId);
			}

			//_orderRepository.Remove(existingOrder);
			existingOrder.Status = OrderStatus.Failed;
			await _orderRepository.SaveChangesAsync();
			_logger.LogInfo($"Xóa thành công đơn hàng với Id {existingOrder.Id}");
		}

		public async Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId)
		{
			var user = await _userRepository.GetByIdAsync(userId);

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			var orders = await _orderRepository.GetOrdersByUserIdAsync(userId);
			_logger.LogInfo($"Lấy dữ liệu đơn hàng thành công cho userId {userId}");
			return _mapper.Map<IEnumerable<OrderDto>>(orders);
		}
	}
}
