using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
