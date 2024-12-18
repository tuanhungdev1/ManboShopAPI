using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
	{
		private readonly ApplicationDbContext _context;
		public CategoryRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<PagedList<Category>> FetchAllCategoriesWithPaging(CategoryRequestParameters categoryRequestParameters)
		{
			var query = _context.Categories.AsNoTracking().AsQueryable();

			if(!string.IsNullOrWhiteSpace(categoryRequestParameters.SearchTerm))
			{
				query = query.Where(c => c.Name.Contains(categoryRequestParameters.SearchTerm));
			}

			if(!string.IsNullOrWhiteSpace(categoryRequestParameters.OrderBy))
			{
				var orderBy = categoryRequestParameters.OrderBy.Trim().ToUpper();

				if(orderBy != "ASC" && orderBy != "DESC")
				{
					throw new CategoryBadRequestException("Điều kiện sắp xếp không hợp lệ. Vui lòng sử dụng ASC hoặc DESC");
				}
				query = orderBy == "ASC" ?
							query.OrderBy(c => c.Name) :
							query.OrderByDescending(c => c.Name);
			}

			var totalCount = await query.CountAsync();

			var items = await query
								.Skip((categoryRequestParameters.PageNumber - 1) * categoryRequestParameters.PageSize)
								.Take(categoryRequestParameters.PageSize)
								.ToListAsync();

			return new PagedList<Category>(items, totalCount, categoryRequestParameters.PageNumber, categoryRequestParameters.PageSize);
		}

		public async Task<Category?> GetCategoryWithProductsAsync(int categoryId)
		{
			return await _context.Categories
				.Include(c => c.Products)
				.FirstOrDefaultAsync(c => c.Id == categoryId);
		}

		
		public async Task<bool> CategoryExistsAsync(string categoryName)
		{
			return await _context.Categories.AnyAsync(c => c.Name == categoryName);
		}
	}
}
