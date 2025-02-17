using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFeedbackRepository : IRepositoryBase<Feedback>
	{
		Task<PagedList<Feedback>> GetAllFeedbackAsync(FeedbackRequestParameters feedbackRequestParameters);
		Task<int> GetFeedbackLikesCountAsync(int feedbackId);
		Task<bool> IsLikedByUserAsync(int feedbackId, int userId);
		Task<Feedback?> GetFeedbackWithDetailsAsync(int id, bool asNoTracking = false);
		Task<PagedList<Feedback>> GetFeedbacksByProductIdAsync(int productId, FeedbackRequestParameters feedbackRequestParameters);
		Task<IEnumerable<Feedback>> GetFeedbacksByUserIdAsync(int userId, bool asNoTracking = false);
		Task<double> GetAverageStarRatingForProductAsync(int productId);
		Task<bool> FeedbackExistsAsync(int id);
		Task<bool> UserHasFeedbackForProductAsync(int userId, int productId);
		Task<IEnumerable<Feedback>> GetFeedbacksByStarRatingAsync(int rating, bool asNoTracking = false);
	}
}
