using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
				.Include(p => p.ProductVariantValues)
				.AsNoTracking()
				.AsQueryable();

			// Search
			if (!string.IsNullOrWhiteSpace(productRequestParameters.SearchTerm))
			{
				string searchTerm = productRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(p =>
					(p.Name != null && p.Name.ToLower().Contains(searchTerm)) ||
					(p.Description != null && p.Description.ToLower().Contains(searchTerm)) ||
					(p.Specification != null && p.Specification.ToLower().Contains(searchTerm))
				);
			}

			// Categories filter
			if (productRequestParameters.Categories?.Any() == true)
			{
				query = query.Where(p => p.Category != null &&
					productRequestParameters.Categories.Contains(p.Category.Name));
			}

			// Brands filter
			if (productRequestParameters.Brands?.Any() == true)
			{
				query = query.Where(p => p.Brand != null &&
					productRequestParameters.Brands.Contains(p.Brand.Name));
			}

			// Price range filter
			if (productRequestParameters.PriceRange != null)
			{
				var priceList = productRequestParameters.PriceRange.Split('-');
				query = query.Where(p =>
					p.Price >= int.Parse(priceList[0]) &&
					p.Price <= int.Parse(priceList[1]));
			}

			if (productRequestParameters.Sizes?.Any() == true)
			{
				var sizeVariantValues = await _context.VariantValues
					.Where(vv => vv.Variant.Name == "Size" &&
						   productRequestParameters.Sizes.Contains(vv.Value))
					.Select(vv => vv.Id)
					.ToListAsync();

				query = query.AsEnumerable() // Chuyển đổi sang LINQ-to-Objects
					.Where(p => p.ProductVariantValues.Any(pv =>
					{
						var skuParts = pv.Sku.Split('-');
						if (skuParts.Length > 0 && int.TryParse(skuParts[0], out int sizeId))
						{
							return sizeVariantValues.Contains(sizeId);
						}
						return false;
					}))
					.AsQueryable();
			}

			// Colors filter  
			if (productRequestParameters.Colors?.Any() == true)
			{
				var colorVariantValues = await _context.VariantValues
					.Where(vv => vv.Variant.Name == "Color" &&
						   productRequestParameters.Colors.Contains(vv.Value))
					.Select(vv => vv.Id)
					.ToListAsync();

				query = query.AsEnumerable() // Chuyển đổi sang LINQ-to-Objects
					.Where(p => p.ProductVariantValues.Any(pv =>
					{
						var skuParts = pv.Sku.Split('-');
						if (skuParts.Length > 1 && int.TryParse(skuParts[1], out int colorId))
						{
							return colorVariantValues.Contains(colorId);
						}
						return false;
					}))
					.AsQueryable();
			}

			// Sorting
			if (!string.IsNullOrWhiteSpace(productRequestParameters.OrderBy))
			{
				var orderBy = productRequestParameters.OrderBy.Trim().ToLower();
				query = orderBy switch
				{
					"price-asc" => query.OrderBy(p => p.Price),
					"price-desc" => query.OrderByDescending(p => p.Price),
					"bestseller" => query.OrderByDescending(p => p.BuyTurn),
					"newest" => query.OrderByDescending(p => p.CreatedAt),
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
				.Include(p => p.ProductVariantValues)
				.ToListAsync();

			return new PagedList<Product>(products, totalCount,
				productRequestParameters.PageNumber,
				productRequestParameters.PageSize);
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
