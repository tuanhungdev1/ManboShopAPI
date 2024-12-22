using Bogus.Extensions.Extras;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class BannerRepository : RepositoryBase<Banner>, IBannerRepository
	{
		public BannerRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<PagedList<Banner>> FetchAllBannerAsync(BannerRequestParameters bannerRequestParameters)
		{
			var query = _dbSet.AsNoTracking().AsQueryable();

			if(!string.IsNullOrWhiteSpace(bannerRequestParameters.SearchTerm))
			{
				query = query.Where(b => b.Name.Contains(bannerRequestParameters.SearchTerm.Trim().ToLower()));
			}

			if(!string.IsNullOrWhiteSpace(bannerRequestParameters.OrderBy))
			{
				var orderKey = bannerRequestParameters.OrderKey?.Trim().ToLower() ?? "";
				var orderBy = bannerRequestParameters.OrderBy.Trim().ToLower();
				query = orderKey switch
				{
					"name" => orderBy == "desc" ? query.OrderByDescending(b => b.Name) : query.OrderBy(b => b.Name),
					"created" => orderBy == "desc" ? query.OrderByDescending(b => b.CreatedAt) : query.OrderBy(b => b.CreatedAt),
					_ => query.OrderBy(b => b.Id),
				};
						
			}


			var totalCount = await query.CountAsync();

			var items = await query
				.Skip((bannerRequestParameters.PageNumber - 1) * bannerRequestParameters.PageSize)
				.Take(bannerRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<Banner>(items, totalCount, bannerRequestParameters.PageNumber, bannerRequestParameters.PageSize);
		}

		public async Task<IEnumerable<Banner>> GetActiveBannersAsync(bool asNoTracking = false)
		{
			var query = _dbSet.Where(b => b.Status == BannerStatus.Active);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<Banner?> GetBannerWithDetailsAsync(int id, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(b => b.BannerDetails)
				.Where(b => b.Id == id);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<bool> IsBannerExistAsync(string name)
		{
			return await _dbSet
				.AsNoTracking()
				.AnyAsync(b => b.Name.ToLower() == name.ToLower());
		}
	}
}
