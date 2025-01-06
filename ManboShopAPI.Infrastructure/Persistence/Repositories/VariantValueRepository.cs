using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class VariantValueRepository : RepositoryBase<VariantValue>, IVariantValueRepository
	{
		public VariantValueRepository(ApplicationDbContext context) : base(context) { }

		public async Task<IEnumerable<VariantValue>> GetByVariantIdAsync(int variantId)
		{
			return await _dbSet
				.Include(vv => vv.Variant)
				.Where(vv => vv.VariantId == variantId)
				.ToListAsync();
		}

		public async Task<bool> IsValueExistAsync(int variantId, string value)
		{
			return await _dbSet
				.AnyAsync(vv => vv.VariantId == variantId &&
							   vv.Value.ToLower() == value.ToLower());
		}

		public async Task<bool> HasAssociatedProductsAsync(int id)
		{
			return await _context.ProductVariantValues
				.AnyAsync(pvv => pvv.Id == id);
		}
	}
}
