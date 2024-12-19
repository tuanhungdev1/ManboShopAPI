using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
	{
		public OrderDetailRepository(ApplicationDbContext context) : base(context) { }

		public async Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(od => od.Product)
				.Include(od => od.Coupon)
				.Where(od => od.OrderId == orderId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<OrderDetail?> GetOrderDetailWithProductAsync(int orderDetailId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(od => od.Product)
				.Include(od => od.Coupon)
				.Where(od => od.Id == orderDetailId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}
	}
}
