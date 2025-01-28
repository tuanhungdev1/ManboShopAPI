using ManboShopAPI.Application.DTOs.AttributeDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IAttributeService
	{
		// Các phương thức quản lý Attribute
		//Task<(IEnumerable<AttributeDto> attributes, MetaData metaData)> GetAllAttributeAsync(
		//	AttributeRequestParameters attributeRequestParameters);
		Task<AttributeDto> GetAttributeByIdAsync(int id);
		Task<AttributeDto> CreateAttributeAsync(AttributeForCreateDto attributeDto);
		Task<AttributeDto> UpdateAttributeAsync(int id, AttributeForUpdateDto attributeDto);
		Task DeleteAttributeAsync(int id);
		Task<bool> AttributeExistsAsync(string name);

		// Các phương thức quản lý ProductAttributeValue
		//Task<ProductAttributeValueDto> AddAttributeValueAsync(ProductAttributeValueForCreateDto valueDto);
		//Task<IEnumerable<ProductAttributeValueDto>> GetAttributeValuesByProductIdAsync(int productId);
		//Task UpdateAttributeValueAsync(ProductAttributeValueForUpdateDto valueDto);
		Task DeleteAttributeValueAsync(int productId, int attributeId);
	}
}
