using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class ProductAttributeValueRepository : RepositoryBase<ProductAttributeValue>, IProductAttributeValueRepository
	{
		public ProductAttributeValueRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<ProductAttributeValue?> GetWithDetailsAsync(int id)
		{
			return await _dbSet
				.Include(pav => pav.Product)
				.Include(pav => pav.Attribute)
				.FirstOrDefaultAsync(pav => pav.Id == id);
		}

		public async Task<IEnumerable<ProductAttributeValue>> GetByProductIdAsync(int productId)
		{
			return await _dbSet
				.Include(pav => pav.Attribute)
				.Where(pav => pav.ProductId == productId)
				.ToListAsync();
		}

		public async Task<IEnumerable<ProductAttributeValue>> GetByAttributeIdAsync(int attributeId)
		{
			return await _dbSet
				.Include(pav => pav.Product)
				.Where(pav => pav.AttributeId == attributeId)
				.ToListAsync();
		}

		public async Task<bool> ExistsAsync(int productId, int attributeId, string value)
		{
			return await _dbSet.AnyAsync(pav =>
				pav.ProductId == productId &&
				pav.AttributeId == attributeId &&
				pav.Value.ToLower() == value.ToLower());
		}

		public async Task<IEnumerable<ProductAttributeValue>> GetProductAttributeValuesWithDetailsAsync()
		{
			return await _dbSet
				.Include(pav => pav.Product)
				.Include(pav => pav.Attribute)
				.ToListAsync();
		}
	}
}
