using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class ProductRepository : RepositoryBase<Product>, IProductRepository
	{
		public ProductRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<Product?> GetProductByIdWithDetailsAsync(int id)
		{
			return await _dbSet
				.Include(p => p.Category)
				.Include(p => p.Brand)
				.Include(p => p.ProductImages)
				.Include(p => p.Feedbacks)
				.FirstOrDefaultAsync(p => p.Id == id);
		}

		public async Task<IEnumerable<Product>> GetProductsWithDetailsAsync()
		{
			return await _dbSet
				.Include(p => p.Category)
				.Include(p => p.Brand)
				.Include(p => p.ProductImages)
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
		{
			return await _dbSet
				.Where(p => p.CategoryId == categoryId)
				.Include(p => p.ProductImages)
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsByBrandIdAsync(int brandId)
		{
			return await _dbSet
				.Where(p => p.BrandId == brandId)
				.Include(p => p.ProductImages)
				.ToListAsync();
		}

		public async Task<bool> ProductExistsAsync(int id)
		{
			return await _dbSet.AnyAsync(p => p.Id == id);
		}

		public async Task<bool> ProductNameExistsAsync(string name)
		{
			return await _dbSet.AnyAsync(p => p.Name == name);
		}
	}
}
