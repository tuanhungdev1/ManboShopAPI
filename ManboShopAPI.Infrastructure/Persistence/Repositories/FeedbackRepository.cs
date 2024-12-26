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

		public async Task<IEnumerable<Feedback>> GetFeedbacksByProductIdAsync(int productId, bool asNoTracking = false)
		{
			IQueryable<Feedback> query = _dbSet
				.Include(f => f.User)
				.Where(f => f.ProductId == productId)
				.OrderByDescending(f => f.CreatedAt);

			if (asNoTracking)
				query = query.AsNoTracking();

			return await query.ToListAsync();
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
			return await _dbSet
				.Where(f => f.ProductId == productId)
				.AverageAsync(f => (double)f.Star);
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
	}
}
