using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IOrderRepository : IRepositoryBase<Order>
	{
		Task<PagedList<Order>> FetchAllOrderAsync(OrderRequestParameters orderRequestParameters);
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, bool asNoTracking = false);
	}
}
