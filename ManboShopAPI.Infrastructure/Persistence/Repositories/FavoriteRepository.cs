using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class FavoriteRepository : RepositoryBase<Favorite>, IFavoriteRepository
	{
		public FavoriteRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Product>> GetProductsByUserIdAsync(int userId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(f => f.Product)
					.ThenInclude(p => p.ProductImages)
				.Include(f => f.Product)
					.ThenInclude(pc => pc.Category)
				.Include(f => f.Product)
					.ThenInclude(pc => pc.Brand)
				.Include(f => f.Product)
					.ThenInclude(p => p.ProductVariantValues)
					.Include(f => f.Product)
					.ThenInclude(p => p.ProductAttributeValues)
				.Where(f => f.UserId == userId)
				.Select(f => f.Product);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}
	}
}
