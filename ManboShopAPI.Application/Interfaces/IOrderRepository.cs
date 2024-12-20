using ManboShopAPI.Application.Common.Request;
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
		Task<PagedList<Order>> FetchAllOrderAsync(OrderRequestParameters orderRequestParameters);
		Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, bool asNoTracking = false);
	}
}
