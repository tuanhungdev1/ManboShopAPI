﻿using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class OrderRepository : RepositoryBase<Order>, IOrderRepository
	{
		public OrderRepository(ApplicationDbContext context) : base(context)
		{
		}

		private IQueryable<Order> ApplyOrdering(IQueryable<Order> query, string orderBy, string orderKey)
		{
			switch (orderBy.ToLower())
			{
				case "newest":
					query = query.OrderByDescending(o => o.CreatedAt);
					break;
				case "oldest":
					query = query.OrderBy(o => o.CreatedAt);
					break;
				case "lowest-price":
					query = query.OrderBy(o => o.Total);
					break;
				case "highest-price":
					query = query.OrderByDescending(o => o.Total);
					break;
				case "most-items":
					query = query.OrderByDescending(o => o.OrderDetails.Count);
					break;
				case "fewest-items":
					query = query.OrderBy(o => o.OrderDetails.Count);
					break;
				default:
					query = query.OrderBy(o => o.Id);
					break;
			}
			return query;
		}

		public async Task<PagedList<Order>> FetchAllOrderAsync(OrderRequestParameters orderRequestParameters)
		{
			var query = _context.Orders
				.Include(o => o.OrderDetails)
					.ThenInclude(od => od.ProductVariantValue)
						.ThenInclude(pvv => pvv.Product)
				.Include(o => o.ShippingAddress)
				.Include(o => o.User)
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(orderRequestParameters.SearchTerm))
			{
				var searchTerm = orderRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(o => o.OrderDetails.Any(od => od.ProductVariantValue.Product.Name.ToLower().Contains(searchTerm)));
			}

			if (!string.IsNullOrWhiteSpace(orderRequestParameters.OrderBy))
			{
				query = ApplyOrdering(query, orderRequestParameters.OrderBy, orderRequestParameters.OrderBy);
			}

			if (orderRequestParameters.OrderStatus.HasValue)
			{
				query = query.Where(order => order.Status == orderRequestParameters.OrderStatus);
			}

			if (orderRequestParameters.FormDate.HasValue)
			{
				var fromDate = orderRequestParameters.FormDate.Value.Date;
				query = query.Where(o => o.CreatedAt >= fromDate);
			}

			if (orderRequestParameters.ToDate.HasValue)
			{
				var toDate = orderRequestParameters.ToDate.Value.Date.AddDays(1);  // Thêm 1 ngày
				query = query.Where(o => o.CreatedAt < toDate);
			}

			if (!string.IsNullOrWhiteSpace(orderRequestParameters.OrderBy))
			{
				query = ApplyOrdering(query, orderRequestParameters.OrderBy, orderRequestParameters.OrderBy);
			}

			var totalCount = await query.CountAsync();


			var items = await query
				.Skip((orderRequestParameters.PageNumber - 1) * orderRequestParameters.PageSize)
				.Take(orderRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<Order>(items, totalCount, orderRequestParameters.PageNumber, orderRequestParameters.PageSize);
		}



		public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId, OrderForUserRequestParameters orderForUserRequestParameters)
		{
			var query = _context.Orders
				.Include(o => o.OrderDetails)
					.ThenInclude(od => od.ProductVariantValue)
						.ThenInclude(pvv => pvv.Product)
				.Include(o => o.ShippingAddress)
				.Include(o => o.User)
				.Where(o => o.UserId == userId)
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(orderForUserRequestParameters.SearchTerm))
			{
				var searchTerm = orderForUserRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(o => o.OrderDetails.Any(od => od.ProductVariantValue.Product.Name.ToLower().Contains(searchTerm)));
			}

			if (!string.IsNullOrWhiteSpace(orderForUserRequestParameters.OrderBy))
			{
				query = ApplyOrdering(query, orderForUserRequestParameters.OrderBy, orderForUserRequestParameters.OrderBy);
			}

			return await query.ToListAsync();
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
