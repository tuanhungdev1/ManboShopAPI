using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IVariantRepository : IRepositoryBase<Variant>
	{
		Task<Variant?> GetVariantWithValuesAsync(int id);
		Task<IEnumerable<Variant>> GetAllVariantsWithValuesAsync();
		Task<bool> IsNameExistAsync(string name);
		Task<bool> IsNameExistAsync(string name, int excludeId);
	}
}
