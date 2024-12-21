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
	public class NewsDetailRepository : RepositoryBase<NewsDetail>, INewsDetailRepository
	{
		public NewsDetailRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<IEnumerable<NewsDetail>> GetByNewsIdAsync(int newsId, bool asNoTracking = false)
		{
			var query = _dbSet.Include(nd => nd.Product)
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
			var query = _dbSet.Include(nd => nd.News)
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
