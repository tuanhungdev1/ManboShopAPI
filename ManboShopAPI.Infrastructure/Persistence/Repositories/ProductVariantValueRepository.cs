using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class ProductVariantValueRepository : RepositoryBase<ProductVariantValue>, IProductVariantValueRepository
	{
		public ProductVariantValueRepository(ApplicationDbContext context) : base(context) { }

		public async Task<IEnumerable<ProductVariantValue>> GetByProductIdAsync(int productId)
		{
			return await _dbSet
				.Include(pvv => pvv.Product)
				.Where(pvv => pvv.ProductId == productId)
				.ToListAsync();
		}

		public async Task<bool> IsSkuExistAsync(string sku)
		{
			return await _dbSet.AnyAsync(pvv => pvv.Sku.ToLower() == sku.ToLower());
		}

		public async Task<bool> IsSkuExistAsync(string sku, int excludeId)
		{
			return await _dbSet
				.AnyAsync(pvv => pvv.Sku.ToLower() == sku.ToLower() &&
								pvv.Id != excludeId);
		}

		public async Task<ProductVariantValue?> GetBySkuAsync(string sku)
		{
			return await _dbSet
				.Include(pvv => pvv.Product)
				.FirstOrDefaultAsync(pvv => pvv.Sku.ToLower() == sku.ToLower());
		}

		public async Task UpdateStockAsync(int id, int quantity)
		{
			var pvv = await _dbSet.FindAsync(id);
			if (pvv != null)
			{
				pvv.Stock = quantity;
				_dbSet.Update(pvv);
				await _context.SaveChangesAsync();
			}
		}
	}
}
