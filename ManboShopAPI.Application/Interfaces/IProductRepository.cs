using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IProductRepository : IRepositoryBase<Product>
	{
		Task<Product?> GetProductByIdWithDetailsAsync(int id);
		Task<IEnumerable<Product>> GetProductsWithDetailsAsync();
		Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
		Task<IEnumerable<Product>> GetProductsByBrandIdAsync(int brandId);
		Task<bool> ProductExistsAsync(int id);
		Task<bool> ProductNameExistsAsync(string name);
	}
}
