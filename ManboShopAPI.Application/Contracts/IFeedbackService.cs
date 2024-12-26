using ManboShopAPI.Application.DTOs.FeedbackDtos;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFeedbackService
	{
		Task<IEnumerable<FeedbackDto>> GetAllFeedbacksAsync();
		Task<FeedbackDto> GetFeedbackByIdAsync(int id);
		Task<IEnumerable<FeedbackDto>> GetFeedbacksByProductIdAsync(int productId);
		Task<IEnumerable<FeedbackDto>> GetFeedbacksByUserIdAsync(int userId);
		Task<IEnumerable<FeedbackDto>> GetFeedbacksByStarRatingAsync(int rating);
		Task<double> GetAverageStarRatingForProductAsync(int productId);
		Task<FeedbackDto> CreateFeedbackAsync(FeedbackForCreateDto feedbackDto);
		Task<FeedbackDto> UpdateFeedbackAsync(int id, FeedbackForUpdateDto feedbackDto);
		Task DeleteFeedbackAsync(int id);
	}
}