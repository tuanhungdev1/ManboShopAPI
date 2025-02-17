using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class FeedbackRepository : RepositoryBase<Feedback>, IFeedbackRepository
	{
		public FeedbackRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<PagedList<Feedback>> GetAllFeedbackAsync(FeedbackRequestParameters feedbackRequestParameters)
		{
			var query = _dbSet
				.AsNoTracking()
				.Include(f => f.User)
				.Include(f => f.Product)
				.OrderByDescending(f => f.CreatedAt)
				.AsQueryable();

			if(!string.IsNullOrWhiteSpace(feedbackRequestParameters.SearchTerm))
			{
				var searchTerm = feedbackRequestParameters.SearchTerm.Trim().ToLower();
				query = query.Where(f => f.Content.ToLower().Contains(searchTerm) || f.Title.ToLower().Contains(searchTerm));
			}

			if (feedbackRequestParameters.RateNumber.HasValue)
			{
				query = query.Where(f => f.Star == feedbackRequestParameters.RateNumber.Value);
			}

			if (feedbackRequestParameters.FromDate.HasValue)
			{
				query = query.Where(f => f.CreatedAt >= feedbackRequestParameters.FromDate.Value);
			}

			if (feedbackRequestParameters.ToDate.HasValue)
			{
				query = query.Where(f => f.CreatedAt <= feedbackRequestParameters.ToDate);
			}

			var totalItems = await query.CountAsync();

			var items = await query
				.Skip(feedbackRequestParameters.PageSize * (feedbackRequestParameters.PageNumber - 1))
				.Take(feedbackRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<Feedback>(items, totalItems, feedbackRequestParameters.PageNumber, feedbackRequestParameters.PageSize);
		}

		public async Task<Feedback?> GetFeedbackWithDetailsAsync(int id, bool asNoTracking = false)
		{
			IQueryable<Feedback> query = _dbSet
				.Include(f => f.User)
				.Include(f => f.Product)
				.Where(f => f.Id == id);

			if (asNoTracking)
				query = query.AsNoTracking();

			return await query.FirstOrDefaultAsync();
		}

		public async Task<PagedList<Feedback>> GetFeedbacksByProductIdAsync(int productId, FeedbackRequestParameters feedbackRequestParameters)
		{
			var query = _dbSet
				.AsNoTracking()
				.Include(f => f.User)
				.Where(f => f.ProductId == productId)
				.OrderByDescending(f => f.CreatedAt);

			var totalItems = await query.CountAsync();


			var items = await query
				.Skip(feedbackRequestParameters.PageSize * (feedbackRequestParameters.PageNumber - 1))
				.Take(feedbackRequestParameters.PageSize)
				.ToListAsync();
			
			return new PagedList<Feedback>(items, totalItems, feedbackRequestParameters.PageNumber, feedbackRequestParameters.PageSize);
		}

		public async Task<IEnumerable<Feedback>> GetFeedbacksByUserIdAsync(int userId, bool asNoTracking = false)
		{
			IQueryable<Feedback> query = _dbSet
				.Include(f => f.Product)
				.Where(f => f.UserId == userId)
				.OrderByDescending(f => f.CreatedAt);

			if (asNoTracking)
				query = query.AsNoTracking();

			return await query.ToListAsync();
		}

		public async Task<double> GetAverageStarRatingForProductAsync(int productId)
		{
			var feedbacks = await _dbSet.Where(f => f.ProductId == productId).ToListAsync();

			// Nếu không có feedback nào, trả về 0
			if (feedbacks.Count == 0)
			{
				return 0;
			}

			return feedbacks.Average(f => (double)f.Star);
		}


		public async Task<bool> FeedbackExistsAsync(int id)
		{
			return await _dbSet.AnyAsync(f => f.Id == id);
		}

		public async Task<bool> UserHasFeedbackForProductAsync(int userId, int productId)
		{
			return await _dbSet.AnyAsync(f => f.UserId == userId && f.ProductId == productId);
		}

		public async Task<IEnumerable<Feedback>> GetFeedbacksByStarRatingAsync(int rating, bool asNoTracking = false)
		{
			IQueryable<Feedback> query = _dbSet
				.Include(f => f.User)
				.Include(f => f.Product)
				.Where(f => f.Star == rating)
				.OrderByDescending(f => f.CreatedAt);

			if (asNoTracking)
				query = query.AsNoTracking();

			return await query.ToListAsync();
		}

		public async Task<bool> IsLikedByUserAsync(int feedbackId, int userId)
		{
			return await _context.FeedbackLikes
				.AnyAsync(fl => fl.FeedbackId == feedbackId && fl.UserId == userId);
		}
		public async Task<int> GetFeedbackLikesCountAsync(int feedbackId)
		{
			return await _dbSet
				.Include(f => f.FeedbackLikes)
				.Where(f => f.Id == feedbackId)
				.Select(f => f.FeedbackLikes.Count)
				.FirstOrDefaultAsync();
		}
	}
}
