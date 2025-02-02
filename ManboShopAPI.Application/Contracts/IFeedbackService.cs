using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFeedbackService
	{
		Task<IEnumerable<FeedbackDto>> GetAllFeedbacksAsync();
		Task<FeedbackDto> GetFeedbackByIdAsync(int id);
		Task<(IEnumerable<FeedbackDto> feedbackDtos, MetaData metaData)> GetFeedbacksByProductIdAsync(
	int productId,
	FeedbackRequestParameters feedbackRequestParameters,
	int? currentUserId = null);
		Task<IEnumerable<FeedbackDto>> GetFeedbacksByUserIdAsync(int userId);
		Task<IEnumerable<FeedbackDto>> GetFeedbacksByStarRatingAsync(int rating);
		Task<double> GetAverageStarRatingForProductAsync(int productId);
		Task<FeedbackDto> CreateFeedbackAsync(int userId, FeedbackForCreateDto feedbackDto);
		Task<FeedbackDto> UpdateFeedbackAsync(int id, FeedbackForUpdateDto feedbackDto);
		Task DeleteFeedbackAsync(int id);

		// Like methods
		Task<FeedbackLikeDto> LikeFeedbackAsync(int feedbackId, int userId);
		Task UnlikeFeedbackAsync(int feedbackId, int userId);
		Task<bool> HasUserLikedFeedbackAsync(int feedbackId, int userId);
		Task<int> GetFeedbackLikesCountAsync(int feedbackId);
		Task<IEnumerable<FeedbackLikeDto>> GetFeedbackLikesAsync(int feedbackId);


		// Report methods
		Task<FeedbackReportDto> ReportFeedbackAsync(int feedbackId, int userId, FeedbackReportForCreateDto reportDto);
		Task<bool> HasUserReportedFeedbackAsync(int feedbackId, int userId);
		Task<IEnumerable<FeedbackReportDto>> GetFeedbackReportsAsync(int feedbackId);
		Task<FeedbackReportDto> UpdateReportStatusAsync(int reportId, ReportStatus status);
		Task DeleteReportAsync(int reportId);
		Task<IEnumerable<FeedbackReportDto>> GetPendingReportsAsync();
	}
}