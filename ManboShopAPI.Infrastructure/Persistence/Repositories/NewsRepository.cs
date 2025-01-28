using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class NewsRepository : RepositoryBase<News>, INewsRepository
	{
		public NewsRepository(ApplicationDbContext context) : base(context)
		{
		}

		

		public async Task<PagedList<News>> FetchAllNewsWithPaging(NewsRequestParameters newsRequestParameters)
		{
			var query = _dbSet
				.Include(n => n.NewsDetails)
					.ThenInclude(nd => nd.Product)
				.AsNoTracking()
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(newsRequestParameters.SearchTerm))
			{
				query = query.Where(n => n.Title.Contains(newsRequestParameters.SearchTerm.Trim().ToLower())
									|| n.Content.Contains(newsRequestParameters.SearchTerm.Trim().ToLower())
									|| n.NewsDetails.Any(nd => nd.Product.Name.Contains(newsRequestParameters.SearchTerm.Trim().ToLower()))
									|| n.NewsDetails.Any(nd => nd.Product.Description.Contains(newsRequestParameters.SearchTerm.Trim().ToLower()))
									);
			}

			if (newsRequestParameters.CategoryId.HasValue)
			{
				query = query.Where(n => n.NewsDetails.Any(nd => nd.Product.CategoryId == newsRequestParameters.CategoryId));
			}

			if(newsRequestParameters.BrandId.HasValue)
			{
				query = query.Where(n => n.NewsDetails.Any(nd => nd.Product.BrandId == newsRequestParameters.BrandId));
			}

			if(!string.IsNullOrWhiteSpace(newsRequestParameters.OrderBy))
			{
				var orderBy = newsRequestParameters.OrderBy.Trim().ToLower();

				query = newsRequestParameters.OrderKey.ToLower() switch
				{
					"desc" => query.OrderByDescending(n => n.CreatedAt),
					"asc" =>  query.OrderBy(n => n.CreatedAt),
					_ => query.OrderByDescending(n => n.CreatedAt)
				};
			}

			var totalCount = await query.CountAsync();

			var items = await query
				.Skip((newsRequestParameters.PageNumber - 1) * newsRequestParameters.PageSize)
				.Take(newsRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<News>(items, totalCount, newsRequestParameters.PageNumber, newsRequestParameters.PageSize);

		}
		public async Task<IEnumerable<News>> GetNewsWithDetailsAsync(bool asNoTracking = false)
		{
			var query = _dbSet.Include(n => n.NewsDetails);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<News?> GetNewsByIdWithDetailsAsync(int id, bool asNoTracking = false)
		{
			var query = _dbSet.Include(n => n.NewsDetails);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync(n => n.Id == id)
				: await query.FirstOrDefaultAsync(n => n.Id == id);
		}

		public async Task<bool> ExistsAsync(int id)
		{
			return await _dbSet.AnyAsync(n => n.Id == id);
		}

		public async Task<bool> TitleExistsAsync(string title)
		{
			return await _dbSet.AnyAsync(n => n.Title == title);
		}
	}
}
