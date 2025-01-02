using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class AttributeRepository : RepositoryBase<Attributes>, IAttributeRepository
	{
		public AttributeRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<Attributes?> GetAttributeWithValuesAsync(int id)
		{
			return await _dbSet
				.Include(a => a.ProductAttributeValues)
				.FirstOrDefaultAsync(a => a.Id == id);
		}

		public async Task<IEnumerable<Attributes>> GetAllAttributesWithValuesAsync()
		{
			return await _dbSet
				.Include(a => a.ProductAttributeValues)
				.ToListAsync();
		}

		public async Task<bool> AttributeExistsAsync(string name)
		{
			return await _dbSet.AnyAsync(a => a.Name.ToLower() == name.ToLower());
		}

		public async Task<bool> HasRelatedProductAttributeValuesAsync(int attributeId)
		{
			return await _context.Set<ProductAttributeValue>()
				.AnyAsync(pav => pav.AttributeId == attributeId);
		}
	}
}
