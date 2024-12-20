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
				.Where(f => f.UserId == userId)
				.Select(f => f.Product);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}
	}
}
