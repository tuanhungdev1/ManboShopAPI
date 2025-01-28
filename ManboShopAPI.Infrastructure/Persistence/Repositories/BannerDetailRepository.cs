using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class BannerDetailRepository : RepositoryBase<BannerDetail>, IBannerDetailRepository
	{
		public BannerDetailRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<BannerDetail>> GetBannerDetailsByBannerIdAsync(int bannerId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(bd => bd.Product)
				.Where(bd => bd.BannerId == bannerId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<IEnumerable<BannerDetail>> GetBannerDetailsByProductIdAsync(int productId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(bd => bd.Banner)
				.Where(bd => bd.ProductId == productId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<BannerDetail?> GetBannerDetailAsync(int bannerId, int productId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(bd => bd.Banner)
				.Include(bd => bd.Product)
				.Where(bd => bd.BannerId == bannerId && bd.ProductId == productId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<bool> IsBannerDetailExistAsync(int bannerId, int productId)
		{
			return await _dbSet
				.AsNoTracking()
				.AnyAsync(bd => bd.BannerId == bannerId && bd.ProductId == productId);
		}
	}
}
