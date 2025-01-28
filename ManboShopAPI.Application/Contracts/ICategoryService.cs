using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.CategoryDtos;

namespace ManboShopAPI.Domain.Interfaces
{
	public interface ICategoryService
	{
		Task<(IEnumerable<CategoryDto> categories, MetaData metaData)> GetAllCategoriesAsync(CategoryRequestParameters categoryRequestParameters);
		Task<CategoryDto> GetCategoryByIdAsync(int categoryId);
		Task CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto);
		Task UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto);
		Task DeleteCategoryAsync(int categoryId);
		Task<bool> CategoryExistsAsync(string categoryName);
		Task<CategoryDto> GetCategoryByNameAsync(string categoryName);
		Task CreateChildCategoriesAsync(int parentCategoryId, IEnumerable<string> childCategoryNames);
	}
}
