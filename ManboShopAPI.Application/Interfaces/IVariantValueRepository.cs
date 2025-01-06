using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IVariantValueRepository : IRepositoryBase<VariantValue>
	{
		Task<IEnumerable<VariantValue>> GetByVariantIdAsync(int variantId);
		Task<bool> IsValueExistAsync(int variantId, string value);
		Task<bool> HasAssociatedProductsAsync(int id);
	}
}
