using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IProductAttributeValueRepository : IRepositoryBase<ProductAttributeValue>
	{
		Task<ProductAttributeValue?> GetWithDetailsAsync(int id);
		Task<IEnumerable<ProductAttributeValue>> GetByProductIdAsync(int productId);
		Task<IEnumerable<ProductAttributeValue>> GetByAttributeIdAsync(int attributeId);
		Task<bool> ExistsAsync(int productId, int attributeId, string value);
		Task<IEnumerable<ProductAttributeValue>> GetProductAttributeValuesWithDetailsAsync();
	}
}
