using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IOrderDetailRepository : IRepositoryBase<OrderDetail>
	{
		Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId, bool asNoTracking = false);
		Task<OrderDetail?> GetOrderDetailWithProductAsync(int orderDetailId, bool asNoTracking = false);
	}
}
