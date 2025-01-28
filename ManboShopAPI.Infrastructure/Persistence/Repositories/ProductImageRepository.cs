using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class ProductImageRepository : RepositoryBase<ProductImage>, IProductImageRepository
	{
		public ProductImageRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<ProductImage>> GetProductImagesByProductIdAsync(int productId, bool asNoTracking = false)
		{
			return await FindByCondition(x => x.ProductId == productId, asNoTracking).ToListAsync();
		}

		public async Task<bool> IsProductImageExistAsync(int productId, string imageUrl)
		{
			return await FindByCondition(x => x.ProductId == productId && x.ImageUrl == imageUrl)
				.AnyAsync();
		}
	}
}
