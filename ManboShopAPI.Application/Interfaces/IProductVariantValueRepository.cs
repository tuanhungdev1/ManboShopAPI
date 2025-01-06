using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IProductVariantValueRepository : IRepositoryBase<ProductVariantValue>
	{
		Task<IEnumerable<ProductVariantValue>> GetByProductIdAsync(int productId);
		Task<bool> IsSkuExistAsync(string sku);
		Task<bool> IsSkuExistAsync(string sku, int excludeId);
		Task<ProductVariantValue?> GetBySkuAsync(string sku);
		Task UpdateStockAsync(int id, int quantity);
	}
}
