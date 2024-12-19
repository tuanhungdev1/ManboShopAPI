using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(ApplicationDbContext context) : base(context) { }

		public async Task<Order?> GetOrderWithDetailsAsync(int orderId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(o => o.OrderDetails)
					.ThenInclude(od => od.Product)
				.Include(o => o.User)
				.Include(o => o.Coupon)
				.Where(o => o.Id == orderId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<Order>> GetUserOrdersAsync(int userId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(o => o.OrderDetails)
				.Where(o => o.UserId == userId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(o => o.OrderDetails)
				.Include(o => o.User)
				.Where(o => o.Status == status);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}
	}
}
