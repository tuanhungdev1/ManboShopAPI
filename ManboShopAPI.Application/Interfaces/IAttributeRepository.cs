using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IAttributeRepository : IRepositoryBase<Attributes>
	{
		Task<Attributes?> GetAttributeWithValuesAsync(int id);
		Task<IEnumerable<Attributes>> GetAllAttributesWithValuesAsync();
		Task<bool> AttributeExistsAsync(string name);
		Task<bool> HasRelatedProductAttributeValuesAsync(int attributeId);
	}
}
