using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.Contracts
{
	public interface IOrderService
	{
		Task SoftDeleteOrderAsync(int orderId);
		Task<OrderDto> UpdateShippingStatusAsync(int order, OrderStatus status, string? note);
		Task<OrderDto> UpdatePaymentStatusAsync(int order, PaymentStatus status, string? note);
		Task<OrderDto> GetOrderByIdAsync(int orderId);
		Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId, OrderForUserRequestParameters orderForUserRequestParameters);
		Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(OrderRequestParameters parameters);
		Task<OrderDto> CreateOrderAsync(OrderForCreateDto orderDto);
		Task<OrderDto> UpdateOrderAsync(int orderId, OrderForUpdateDto orderDto);
		Task DeleteOrderAsync(int orderId);
		Task<OrderDto> UpdateOrderStatusAsync(int orderId, OrderStatus status);
		Task<Dictionary<OrderStatus, int>> GetOrderStatusStatisticsAsync();
		Task<decimal> GetTotalRevenueAsync();
		Task<decimal> GetDailyRevenueAsync(DateTime date);
		Task<IEnumerable<OrderDto>> GetRecentOrdersAsync(int count);
		Task<IEnumerable<OrderDto>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate);
		Task<bool> HasUserPurchasedProductAsync(int userId, int productId);
		Task<OrderDto> CancelOrderAsync(int orderId, int userId, string? cancellationReason);
	}
}
