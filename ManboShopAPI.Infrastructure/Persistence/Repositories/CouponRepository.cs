

using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CouponRepository : RepositoryBase<Coupon>, ICouponRepository
	{
        public CouponRepository(ApplicationDbContext context) : base(context)
        {
            
        }

		private IQueryable<Coupon> ApplyOrdering(IQueryable<Coupon> query, string orderBy)
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

		public async Task<bool> CodeExistsAsync(string code)
		{
			return await _dbSet.AnyAsync(c => c.Code == code);
		}

		public async Task<Coupon> GetByCodeAsync(string code)
		{
			return await _dbSet.FirstOrDefaultAsync(c => c.Code == code);
		}

		public async Task<PagedList<Coupon>> GetAllCouponsAsync(CouponRequestParameters parameters)
		{
			var query = _context.Coupons.AsQueryable();

			if(parameters.SearchTerm != null)
			{	
				var searchTerm = parameters.SearchTerm.Trim().ToLower();
				query = query.Where(c => c.Code.ToLower().Contains(parameters.SearchTerm));
			}

			if (parameters.IsActive.HasValue)
			{
				query = query.Where(c => c.IsActive == parameters.IsActive);
			}

			if (parameters.FormDate.HasValue)
			{
				query = query.Where(c => c.StartDate >= parameters.FormDate);
			}

			if (parameters.ToDate.HasValue)
			{
				query = query.Where(c => c.EndDate <= parameters.ToDate);
			}

			var totalCount = await query.CountAsync();

			var items = await query
								.Skip((parameters.PageNumber - 1) * parameters.PageSize)
								.Take(parameters.PageSize)
								.ToListAsync();

			return new PagedList<Coupon>(items, totalCount, parameters.PageNumber, parameters.PageSize);
		}
	}
}
