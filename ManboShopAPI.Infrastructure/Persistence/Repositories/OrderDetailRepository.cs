using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Infrastructure.Persistence.Repositories;
using ManboShopAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
{
	public OrderDetailRepository(ApplicationDbContext context) : base(context)
	{
	}

	public async Task<OrderDetail?> GetOrderDetailByIdWithRelationsAsync(int id, bool asNoTracking = false)
	{
		IQueryable<OrderDetail> query = _dbSet
			.Include(od => od.Order)
			.Include(od => od.Product)
		.Include(od => od.Coupon);

		if (asNoTracking)
			query = query.AsNoTracking();

		return await query.FirstOrDefaultAsync(od => od.Id == id);
	}

	public async Task<IEnumerable<OrderDetail>> GetOrderDetailsByOrderIdAsync(int orderId, bool asNoTracking = false)
	{
		IQueryable<OrderDetail> query = _dbSet
			.Include(od => od.Product)
			.Include(od => od.Coupon)
			.Where(od => od.OrderId == orderId);

		if (asNoTracking)
			query = query.AsNoTracking();

		return await query.ToListAsync();
	}

	public async Task<IEnumerable<OrderDetail>> GetOrderDetailsByProductIdAsync(int productId, bool asNoTracking = false)
	{
		IQueryable<OrderDetail> query = _dbSet
			.Include(od => od.Order)
			.Include(od => od.Coupon)
			.Where(od => od.ProductId == productId);

		if (asNoTracking)
			query = query.AsNoTracking();

		return await query.ToListAsync();
	}

	public async Task<decimal> GetTotalPriceByOrderIdAsync(int orderId)
	{
		return await _dbSet
			.Where(od => od.OrderId == orderId)
			.SumAsync(od => od.Price * od.Quantity);
	}

	public async Task<bool> IsOrderDetailExistAsync(int id)
	{
		return await _dbSet.AnyAsync(od => od.Id == id);
	}

	public async Task<IEnumerable<OrderDetail>> GetOrderDetailsWithRelationsAsync(
		Expression<Func<OrderDetail, bool>>? filter = null,
		bool asNoTracking = false)
	{
		IQueryable<OrderDetail> query = _dbSet
			.Include(od => od.Order)
			.Include(od => od.Product)
			.Include(od => od.Coupon);

		if (filter != null)
			query = query.Where(filter);

		if (asNoTracking)
			query = query.AsNoTracking();

		return await query.ToListAsync();
	}
}