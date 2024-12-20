using ManboShopAPI.Application.Common.Request;
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
	}
}
