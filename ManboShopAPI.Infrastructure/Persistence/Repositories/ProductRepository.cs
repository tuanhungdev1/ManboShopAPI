using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
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

		public async Task<PagedList<Product>> GetProductsWithDetailsAsync(ProductRequestParameters productRequestParameters)
		{

			var query = _dbSet
				.Include(p => p.Category)
				.Include(p => p.Brand)
				.Include(p => p.ProductImages)
				.AsNoTracking()
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(productRequestParameters.SearchTerm))
			{
				string searchTerm = productRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(p =>
					(p.Name != null && p.Name.ToLower().Contains(searchTerm)) ||
					(p.Description != null && p.Description.ToLower().Contains(searchTerm)) ||
					(p.Specification != null && p.Specification.ToLower().Contains(searchTerm))
				);
			}

			if (productRequestParameters.CategoryId.HasValue)
			{
				query = query.Where(p => p.CategoryId == productRequestParameters.CategoryId);
			}

			if (productRequestParameters.BrandId.HasValue)
			{
				query = query.Where(p => p.BrandId == productRequestParameters.BrandId);
			}

			if (productRequestParameters.MinPrice.HasValue)
			{
				query = query.Where(p => p.Price >= productRequestParameters.MinPrice);
			}

			if (productRequestParameters.MaxPrice.HasValue)
			{
				query = query.Where(p => p.Price <= productRequestParameters.MaxPrice);
			}

			
			if (!string.IsNullOrWhiteSpace(productRequestParameters.OrderBy))
			{
				var orderBy = productRequestParameters.OrderBy.Trim().ToLower();

				query = orderBy switch
				{
					"asc" => query.OrderBy(p => p.Name),
					"desc" => query.OrderByDescending(p => p.Name),
					_ => query
				};
			}

			if(!string.IsNullOrWhiteSpace(productRequestParameters.OrderPrice))
			{
				var orderPrice = productRequestParameters.OrderPrice.Trim().ToLower();

				query = orderPrice switch
				{
					"asc" => query.OrderBy(p => p.Price),
					"desc" => query.OrderByDescending(p => p.Price),
					_ => query
				};
			}

			var totalCount = await query.CountAsync();

			var products = await query
				.Skip((productRequestParameters.PageNumber - 1) * productRequestParameters.PageSize)
				.Take(productRequestParameters.PageSize)
				.Include(p => p.ProductImages)
				.Include(p => p.Category)
				.Include(p => p.Brand)
				.ToListAsync();

			return new PagedList<Product>(products, totalCount, productRequestParameters.PageNumber, productRequestParameters.PageSize);
		}

		public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
		{
			return await _dbSet
				.Where(p => p.CategoryId == categoryId)
				.Include(p => p.Category)
				.Include(p => p.Brand)
				.Include(p => p.ProductImages)
				.ToListAsync();
		}

		public async Task<IEnumerable<Product>> GetProductsByBrandIdAsync(int brandId)
		{
			return await _dbSet
				.Where(p => p.BrandId == brandId)
				.Include(p => p.Category)
				.Include(p => p.Brand)
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
