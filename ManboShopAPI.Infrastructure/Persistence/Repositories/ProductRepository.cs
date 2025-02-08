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
				.Include(P => P.ProductAttributeValues)
				.AsNoTracking()
				.AsQueryable();

			Console.WriteLine("🔍 Initial Query: " + query.ToQueryString());

			// Search
			if (!string.IsNullOrWhiteSpace(productRequestParameters.SearchTerm))
			{
				string searchTerm = productRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(p =>
					(p.Name != null && p.Name.ToLower().Contains(searchTerm)) ||
					(p.Description != null && p.Description.ToLower().Contains(searchTerm)) ||
					(p.Specification != null && p.Specification.ToLower().Contains(searchTerm))
				);

				Console.WriteLine($"🔍 Search Term: {searchTerm}");
				Console.WriteLine("📌 Query after search filter: " + query.ToQueryString());
			}

			// Categories filter
			if (productRequestParameters.Categories?.Any() == true)
			{
				Console.WriteLine("📌 Filtering by categories: " + string.Join(", ", productRequestParameters.Categories));
				query = query.Where(p => p.Category != null &&
					productRequestParameters.Categories.Contains(p.Category.Name));

				Console.WriteLine("📌 Query after category filter: " + query.ToQueryString());
			}

			// Brands filter
			if (productRequestParameters.Brands?.Any() == true)
			{
				Console.WriteLine("📌 Filtering by brands: " + string.Join(", ", productRequestParameters.Brands));
				query = query.Where(p => p.Brand != null &&
					productRequestParameters.Brands.Contains(p.Brand.Name));

				Console.WriteLine("📌 Query after brand filter: " + query.ToQueryString());
			}

			// Price range filter
			if (productRequestParameters.PriceRange != null)
			{
				var priceList = productRequestParameters.PriceRange.Split('-');
				int minPrice = int.Parse(priceList[0]);
				int maxPrice = int.Parse(priceList[1]);

				Console.WriteLine($"📌 Filtering by price range: {minPrice} - {maxPrice}");
				query = query.Where(p => p.Price >= minPrice && p.Price <= maxPrice);

				Console.WriteLine("📌 Query after price filter: " + query.ToQueryString());
			}

			// Sorting
			if (!string.IsNullOrWhiteSpace(productRequestParameters.OrderBy))
			{
				var orderBy = productRequestParameters.OrderBy.Trim().ToLower();
				Console.WriteLine($"📌 Sorting by: {orderBy}");

				query = orderBy switch
				{
					"price-asc" => query.OrderBy(p => p.Price),
					"price-desc" => query.OrderByDescending(p => p.Price),
					"bestseller" => query.OrderByDescending(p => p.BuyTurn),
					"newest" => query.OrderByDescending(p => p.CreatedAt),
					_ => query
				};

				Console.WriteLine("📌 Query after sorting: " + query.ToQueryString());
			}

			// Filtering by Sizes & Colors
			if (productRequestParameters.Sizes?.Any() == true || productRequestParameters.Colors?.Any() == true)
			{
				Console.WriteLine("📌 Filtering by Sizes or Colors...");

				var variantValues = await _context.VariantValues
					.Where(vv => (vv.Variant.Name == "Size" && productRequestParameters.Sizes.Contains(vv.Value)) ||
								 (vv.Variant.Name == "Màu" && productRequestParameters.Colors.Contains(vv.Value)))
					.Select(vv => vv.Id)
					.ToListAsync();

				Console.WriteLine("📌 Variant IDs retrieved: " + string.Join(", ", variantValues));

				query = query.Where(p => p.ProductVariantValues.Any(pvv =>
					 variantValues.Any(id => pvv.Sku.Contains(id.ToString()))));

				Console.WriteLine("📌 Query after filtering by Sizes & Colors: " + query.ToQueryString());
			}

			var totalCount = await query.CountAsync();
			Console.WriteLine($"📌 Total products found: {totalCount}");

			var products = await query
				.Skip((productRequestParameters.PageNumber - 1) * productRequestParameters.PageSize)
				.Take(productRequestParameters.PageSize)
				.ToListAsync();

			Console.WriteLine($"📌 Returning {products.Count} products (Page {productRequestParameters.PageNumber})");

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
