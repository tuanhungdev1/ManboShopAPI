using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFeedbackRepository : IRepositoryBase<Feedback>
	{
		Task<Feedback?> GetFeedbackWithDetailsAsync(int id, bool asNoTracking = false);
		Task<IEnumerable<Feedback>> GetFeedbacksByProductIdAsync(int productId, bool asNoTracking = false);
		Task<IEnumerable<Feedback>> GetFeedbacksByUserIdAsync(int userId, bool asNoTracking = false);
		Task<double> GetAverageStarRatingForProductAsync(int productId);
		Task<bool> FeedbackExistsAsync(int id);
		Task<bool> UserHasFeedbackForProductAsync(int userId, int productId);
		Task<IEnumerable<Feedback>> GetFeedbacksByStarRatingAsync(int rating, bool asNoTracking = false);
	}
}
