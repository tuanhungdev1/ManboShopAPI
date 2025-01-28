using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System.Linq.Expressions;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IOrderDetailRepository : IRepositoryBase<OrderDetail>
	{
		Task<OrderDetail?> GetOrderDetailByIdWithRelationsAsync(int id, bool asNoTracking = false);
		Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId, bool asNoTracking = false);
		Task<IEnumerable<OrderDetail>> GetOrderDetailsByProductIdAsync(int productId, bool asNoTracking = false);
		Task<decimal> GetTotalPriceByOrderIdAsync(int orderId);
		Task<bool> IsOrderDetailExistAsync(int id);
		Task<IEnumerable<OrderDetail>> GetOrderDetailsWithRelationsAsync(Expression<Func<OrderDetail, bool>>? filter = null, bool asNoTracking = false);
	}
}
