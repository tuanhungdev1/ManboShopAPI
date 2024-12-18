using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
