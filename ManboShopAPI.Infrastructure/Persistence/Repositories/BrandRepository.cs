using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
	{
		public BrandRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<Brand?> GetBrandWithProductsAsync(int brandId)
		{
			return await _context.Brands
				.Include(b => b.Products)
				.FirstOrDefaultAsync(b => b.Id == brandId);
		}

		public async Task<bool> BrandExistsAsync(string brandName)
		{
			return await _context.Brands
				.AnyAsync(b => b.Name.Trim().ToLower() == brandName.Trim().ToLower());
		}

		public async Task<bool> BrandExistsByIdAsync(int brandId)
		{
			return await _context.Brands
				.AnyAsync(b => b.Id == brandId);
		}

		public async Task<PagedList<Brand>> FetchAllCategoriesWithPaging(BrandRequestParameters brandRequestParameters)
		{
			var query = _context.Brands.AsNoTracking().AsQueryable();

			if (!string.IsNullOrWhiteSpace(brandRequestParameters.SearchTerm))
			{
				query = query.Where(b =>
					b.Name.ToLower().Contains(brandRequestParameters.SearchTerm.ToLower()));
			}

			if(!string.IsNullOrWhiteSpace(brandRequestParameters.OrderBy))
			{
				var orderBy = brandRequestParameters.OrderBy.Trim().ToUpper();

				if(orderBy != "ASC" && orderBy != "DESC")
				{
					throw new BrandBadRequestException("Điều kiện sắp xếp không hợp lệ. Vui lòng sử dụng ASC hoặc DESC");
				}

				query = orderBy == "ASC" ?
						query.OrderBy(b => b.Name) :
						query.OrderByDescending(b => b.Name);
			}
			
			var totalCount = await query.CountAsync();

			var items = await query
								.Skip((brandRequestParameters.PageNumber - 1) * brandRequestParameters.PageSize)
								.Take(brandRequestParameters.PageSize)
								.ToListAsync();

			return new PagedList<Brand>(items, totalCount, brandRequestParameters.PageNumber, brandRequestParameters.PageSize);
		}
	}
}
