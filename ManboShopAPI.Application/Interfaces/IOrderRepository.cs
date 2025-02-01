using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IOrderRepository : IRepositoryBase<Order>
	{
		Task<Order?> GetOrderByIdWithDetailsAsync(int orderId, bool asNoTracking = false);
		Task<bool> OrderExistsAsync(int orderId);
		Task<decimal> GetTotalOrderAmountByUserIdAsync(int userId);
		Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status, bool asNoTracking = false);
		Task<int> GetTotalOrdersCountAsync();
		Task<Dictionary<OrderStatus, int>> GetOrderStatusStatisticsAsync();
		Task UpdateOrderStatusAsync(int orderId, OrderStatus newStatus);
		Task<IEnumerable<Order>> GetRecentOrdersAsync(int count, bool asNoTracking = false);
		Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate, bool asNoTracking = false);
		Task<decimal> GetDailyRevenueAsync(DateTime date);
		Task<bool> HasUserPurchasedProductAsync(int userId, int productId);
		Task<PagedList<Order>> FetchAllOrderAsync(OrderRequestParameters orderRequestParameters);
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, bool asNoTracking = false);
	}
}
