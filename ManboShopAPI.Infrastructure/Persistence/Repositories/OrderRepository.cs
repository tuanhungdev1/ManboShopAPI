using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(ApplicationDbContext context) : base(context)
		{
		}

		private IQueryable<Order> ApplyOrdering(IQueryable<Order> query, string orderBy, string orderKey)
		{
			switch (orderKey.ToLower())
			{
				case "createdat":
					query = orderBy?.ToLower() == "desc" ? query.OrderByDescending(o => o.CreatedAt) : query.OrderBy(o => o.CreatedAt);
					break;
				case "total":
					query = orderBy?.ToLower() == "desc" ? query.OrderByDescending(o => o.Total) : query.OrderBy(o => o.Total);
					break;
				case "status":
					query = orderBy?.ToLower() == "desc" ? query.OrderByDescending(o => o.Status) : query.OrderBy(o => o.Status);
					break;
				case "username":
					query = orderBy?.ToLower() == "desc" ? query.OrderByDescending(o => o.User.UserName) : query.OrderBy(o => o.User.UserName);
					break;
				default:
					query = query.OrderBy(o => o.Id); // Default ordering
					break;
			}
			return query;
		}

		public async Task<PagedList<Order>> FetchAllOrderAsync(OrderRequestParameters orderRequestParameters)
		{
			var query = _dbSet.AsNoTracking()
				.Include(o => o.User)
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(orderRequestParameters.SearchTerm))
			{
				var searchTerm = orderRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(order => order.User.LastName.ToLower().Contains(searchTerm) ||
											 order.User.FirstName.ToLower().Contains(searchTerm) ||
											 order.User.UserName.ToLower().Contains(searchTerm) ||
											 order.User.Email.ToLower().Contains(searchTerm));
			}

			if (orderRequestParameters.OrderStatus.HasValue)
			{
				query = query.Where(order => order.Status == orderRequestParameters.OrderStatus);
			}

			if (orderRequestParameters.FormDate.HasValue)
			{
				query = query.Where(order => order.CreatedAt >= orderRequestParameters.FormDate.Value);
			}
			if (orderRequestParameters.ToDate.HasValue)
			{
				query = query.Where(order => order.CreatedAt <= orderRequestParameters.ToDate.Value);
			}

			if (!string.IsNullOrWhiteSpace(orderRequestParameters.OrderBy))
			{
				query = ApplyOrdering(query, orderRequestParameters.OrderBy, orderRequestParameters.OrderKey);
			}

			var totalCount = await query.CountAsync();


			var items = await query
				.Skip((orderRequestParameters.PageNumber - 1) * orderRequestParameters.PageSize)
				.Take(orderRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<Order>(items, totalCount, orderRequestParameters.PageNumber, orderRequestParameters.PageSize);
		}

		public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, bool asNoTracking = false)
		{
			return await FindByCondition(order => order.UserId == userId, asNoTracking).ToListAsync();
		}


		public async Task<Order?> GetOrderByIdWithDetailsAsync(int orderId, bool asNoTracking = false)
		{
			var query = _context.Orders
				.Include(o => o.User)
				.Include(o => o.OrderDetails)
					.ThenInclude(od => od.ProductVariantValue)
						.ThenInclude(pvv => pvv.Product)
				.Where(o => o.Id == orderId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<bool> OrderExistsAsync(int orderId)
		{
			return await _context.Orders.AnyAsync(o => o.Id == orderId);
		}

		public async Task<decimal> GetTotalOrderAmountByUserIdAsync(int userId)
		{
			return await _context.Orders
				.Where(o => o.UserId == userId)
				.SumAsync(o => o.Total);
		}

		public async Task<IEnumerable<Order>> GetOrdersByStatusAsync(OrderStatus status, bool asNoTracking = false)
		{
			var query = _context.Orders
				.Include(o => o.User)
				.Include(o => o.OrderDetails)
				.Where(o => o.Status == status);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<int> GetTotalOrdersCountAsync()
		{
			return await _context.Orders.CountAsync();
		}

		public async Task<Dictionary<OrderStatus, int>> GetOrderStatusStatisticsAsync()
		{
			return await _context.Orders
				.GroupBy(o => o.Status)
				.ToDictionaryAsync(
					g => g.Key,
					g => g.Count()
				);
		}

		public async Task UpdateOrderStatusAsync(int orderId, OrderStatus newStatus)
		{
			var order = await _context.Orders.FindAsync(orderId);
			if (order != null)
			{
				order.Status = newStatus;
				_context.Orders.Update(order);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IEnumerable<Order>> GetRecentOrdersAsync(int count, bool asNoTracking = false)
		{
			var query = _context.Orders
				.Include(o => o.User)
				.Include(o => o.OrderDetails)
				.OrderByDescending(o => o.CreatedAt)
				.Take(count);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(
			DateTime startDate,
			DateTime endDate,
			bool asNoTracking = false)
		{
			var query = _context.Orders
				.Include(o => o.User)
				.Include(o => o.OrderDetails)
				.Where(o => o.CreatedAt >= startDate && o.CreatedAt <= endDate);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<decimal> GetDailyRevenueAsync(DateTime date)
		{
			return await _context.Orders
				.Where(o => o.CreatedAt.Date == date.Date)
				.SumAsync(o => o.Total);
		}

		public async Task<bool> HasUserPurchasedProductAsync(int userId, int productId)
		{
			return await _context.Orders
				.Where(o => o.UserId == userId)
				.AnyAsync(o => o.OrderDetails
					.Any(od => od.ProductVariantValue.ProductId == productId));
		}
	}
}
