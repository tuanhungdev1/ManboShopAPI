using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
	{
		public CategoryRepository(ApplicationDbContext context) : base(context)
		{
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
