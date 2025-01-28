using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class NewsDetailRepository : RepositoryBase<NewsDetail>, INewsDetailRepository
	{
		public NewsDetailRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<PagedList<NewsDetail>> FetchAllNewsDetailsAsync(NewsDetailRequestParameters newsDetailRequestParameters)
		{
			var query = _dbSet
				.Include(nd => nd.News)
				.Include(nd => nd.Product)
				.AsNoTracking()
				.AsQueryable();

			if (!string.IsNullOrWhiteSpace(newsDetailRequestParameters.SearchTerm))
			{
				query = query.Where(nd => nd.Product.Name.Contains(newsDetailRequestParameters.SearchTerm)
										|| nd.News.Title.Contains(newsDetailRequestParameters.SearchTerm)
				);
			}

			if(newsDetailRequestParameters.NewsId != null)
			{
				query = query.Where(nd => nd.NewsId == newsDetailRequestParameters.NewsId);
			}

			if(newsDetailRequestParameters.ProductId != null)
			{
				query = query.Where(nd => nd.ProductId == newsDetailRequestParameters.ProductId);
			}

			if(!string.IsNullOrWhiteSpace(newsDetailRequestParameters.OrderBy))
			{
				query = newsDetailRequestParameters.OrderBy switch
				{
					"asc" => query.OrderBy(nd => nd.NewsId),
					"desc" => query.OrderByDescending(nd => nd.NewsId),
					_ => query.OrderBy(nd => nd.NewsId)
				};
			}

			var totalCount = await query.CountAsync();

			var items = await query
				.Skip(newsDetailRequestParameters.PageSize * (newsDetailRequestParameters.PageNumber - 1))
				.Take(newsDetailRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<NewsDetail>(items, totalCount, newsDetailRequestParameters.PageNumber, newsDetailRequestParameters.PageSize);
		} 

		public async Task<IEnumerable<NewsDetail>> GetByNewsIdAsync(int newsId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(nd => nd.Product)
				.Where(nd => nd.NewsId == newsId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<bool> ExistsAsync(int newsId, int productId)
		{
			return await _dbSet.AnyAsync(nd => nd.NewsId == newsId && nd.ProductId == productId);
		}

		public async Task<IEnumerable<NewsDetail>> GetByProductIdAsync(int productId, bool asNoTracking = false)
		{
			var query = _dbSet
						.Include(nd => nd.News)
						.Where(nd => nd.ProductId == productId);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task AddNewsDetailsAsync(int newsId, IEnumerable<int> productIds)
		{
			var newsDetails = productIds.Select(productId => new NewsDetail
			{
				NewsId = newsId,
				ProductId = productId
			});

			await AddRangeAsync(newsDetails);
		}

		public async Task RemoveNewsDetailsAsync(int newsId)
		{
			var newsDetails = await _dbSet.Where(nd => nd.NewsId == newsId).ToListAsync();
			RemoveRange(newsDetails);
		}
	}
}
