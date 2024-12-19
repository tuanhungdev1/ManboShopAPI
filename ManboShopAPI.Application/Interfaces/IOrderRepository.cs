using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IOrderRepository : IRepositoryBase<Order>
	{
		Task<Order?> GetOrderWithDetailsAsync(int orderId, bool asNoTracking = false);
		Task<IEnumerable<Order>> GetUserOrdersAsync(int userId, bool asNoTracking = false);
		Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status, bool asNoTracking = false);
	}
}
