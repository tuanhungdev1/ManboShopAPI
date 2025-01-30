using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.Contracts
{
	public interface IOrderService
	{
		Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(
		OrderRequestParameters parameters);
		Task<OrderDto> GetOrderByIdAsync(int orderId);
		Task<OrderDto> CreateOrderAsync(OrderForCreateDto orderForCreateDto);
		Task UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
		Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId);
		Task CancelOrderAsync(int orderId);
	}
}
