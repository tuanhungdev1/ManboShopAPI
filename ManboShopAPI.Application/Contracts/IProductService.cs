﻿using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IProductService
	{
		Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetAllProductsAsync(ProductRequestParameters productRequestParameters);
		Task<ProductDto> GetProductByIdAsync(int id);
		Task<ProductDto> GetProductBySlugNameAsync(string slugName);
		Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId);
		Task<IEnumerable<ProductDto>> GetProductsByBrandAsync(int brandId);
		Task<ProductDto> CreateProductAsync(ProductForCreateDto productDto);
		Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productDto);
		Task DeleteProductAsync(int id);
		Task<bool> ProductExistsAsync(int id);
		Task UpdateProductQuantityAsync(int id, int quantity);
	}
}
