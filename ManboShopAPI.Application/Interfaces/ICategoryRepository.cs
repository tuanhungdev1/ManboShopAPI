﻿using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Domain.Interfaces
{
	public interface ICategoryRepository : IRepositoryBase<Category>
	{
		Task<PagedList<Category>> FetchAllCategoriesWithPaging(CategoryRequestParameters categoryRequestParameters);
		Task<Category?> GetCategoryWithProductsAsync(int categoryId);
		Task<bool> CategoryExistsAsync(string categoryName);
		Task<bool> CategoryExistsByIdAsync(int categoryId);
	}
}
