using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class FeedbacksController : ControllerBase
	{
		private readonly IFeedbackService _feedbackService;

		public FeedbacksController(IFeedbackService feedbackService)
		{
			_feedbackService = feedbackService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetFeedbacks()
		{
			var feedbacks = await _feedbackService.GetAllFeedbacksAsync();
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách đánh giá thành công.",
				Data = feedbacks
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetFeedback))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<FeedbackDto>> GetFeedback(int id)
		{
			var feedback = await _feedbackService.GetFeedbackByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin đánh giá với Id {id} thành công.",
				Data = feedback
			});
		}

		[HttpGet("product/{productId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetFeedbacksByProduct(int productId, [FromQuery] FeedbackRequestParameters feedbackRequestParameters)
		{

			int? currentUserId = User.Identity.IsAuthenticated ?
				int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value) :
				null;
			var feedbacks = await _feedbackService.GetFeedbacksByProductIdAsync(productId, feedbackRequestParameters, currentUserId);
			return Ok(new ApiResponse<IEnumerable<FeedbackDto>>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách đánh giá của sản phẩm Id {productId} thành công.",
				Data = feedbacks.feedbackDtos,
				Pagination = feedbacks.metaData
			});
		}

		[HttpGet("user/{userId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetFeedbacksByUser(int userId)
		{
			var feedbacks = await _feedbackService.GetFeedbacksByUserIdAsync(userId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách đánh giá của người dùng Id {userId} thành công.",
				Data = feedbacks
			});
		}

		[HttpGet("rating/{rating:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetFeedbacksByRating(int rating)
		{
			var feedbacks = await _feedbackService.GetFeedbacksByStarRatingAsync(rating);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách đánh giá {rating} sao thành công.",
				Data = feedbacks
			});
		}

		[HttpGet("product/{productId:int}/average-rating")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<double>> GetAverageRating(int productId)
		{
			var averageRating = await _feedbackService.GetAverageStarRatingForProductAsync(productId);
			return Ok(new ApiResponse<double>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy điểm đánh giá trung bình của sản phẩm Id {productId} thành công.",
				Data = averageRating
			});
		}

		[HttpPost]
		[Authorize]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateFeedback([FromBody] FeedbackForCreateDto feedbackForCreateDto)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var feedback = await _feedbackService.CreateFeedbackAsync(userId, feedbackForCreateDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới đánh giá thành công.",
				Data = feedback
			});
		}

		[HttpPut("{id:int}")]
		[Authorize]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateFeedback(int id, [FromBody] FeedbackForUpdateDto feedbackForUpdateDto)
		{
			var feedback = await _feedbackService.UpdateFeedbackAsync(id, feedbackForUpdateDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật đánh giá với Id {id} thành công.",
				Data = feedback
			});
		}

		[HttpDelete("{id:int}")]
		[Authorize]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteFeedback(int id)
		{
			await _feedbackService.DeleteFeedbackAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa đánh giá với Id {id} thành công."
			});
		}



		[HttpPost("{id:int}/like")]
		[Authorize]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<FeedbackLikeDto>> LikeFeedback(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var like = await _feedbackService.LikeFeedbackAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Đã thích đánh giá.",
				Data = like
			});
		}

		[HttpDelete("{id:int}/like")]
		[Authorize]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<IActionResult> UnlikeFeedback(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			await _feedbackService.UnlikeFeedbackAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Đã bỏ thích đánh giá."
			});
		}

		[HttpGet("{id:int}/likes")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<IEnumerable<FeedbackLikeDto>>> GetFeedbackLikes(int id)
		{
			var likes = await _feedbackService.GetFeedbackLikesAsync(id);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách lượt thích thành công.",
				Data = likes
			});
		}

		[HttpGet("{id:int}/likes/count")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<int>> GetFeedbackLikesCount(int id)
		{
			var count = await _feedbackService.GetFeedbackLikesCountAsync(id);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy số lượt thích thành công.",
				Data = count
			});
		}

		[HttpGet("{id:int}/likes/check")]
		[Authorize]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<bool>> CheckUserLiked(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var hasLiked = await _feedbackService.HasUserLikedFeedbackAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Kiểm tra lượt thích thành công.",
				Data = hasLiked
			});
		}

		// Report endpoints
		[HttpPost("{id:int}/report")]
		[Authorize]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		public async Task<ActionResult<FeedbackReportDto>> ReportFeedback(
			int id,
			[FromBody] FeedbackReportForCreateDto reportDto)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var report = await _feedbackService.ReportFeedbackAsync(id, userId, reportDto);

			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Đã báo cáo đánh giá.",
				Data = report
			});
		}

		[HttpGet("{id:int}/reports")]
		[Authorize(Roles = "Admin")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<IEnumerable<FeedbackReportDto>>> GetFeedbackReports(int id)
		{
			var reports = await _feedbackService.GetFeedbackReportsAsync(id);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách báo cáo thành công.",
				Data = reports
			});
		}

		[HttpPut("reports/{reportId:int}/status")]
		[Authorize(Roles = "Admin")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<FeedbackReportDto>> UpdateReportStatus(
			int reportId,
			[FromBody] ReportStatus status)
		{
			var report = await _feedbackService.UpdateReportStatusAsync(reportId, status);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Cập nhật trạng thái báo cáo thành công.",
				Data = report
			});
		}

		[HttpGet("reports/pending")]
		[Authorize(Roles = "Admin")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<IEnumerable<FeedbackReportDto>>> GetPendingReports()
		{
			var reports = await _feedbackService.GetPendingReportsAsync();

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách báo cáo đang chờ xử lý thành công.",
				Data = reports
			});
		}

		[HttpDelete("reports/{reportId:int}")]
		[Authorize(Roles = "Admin")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<IActionResult> DeleteReport(int reportId)
		{
			await _feedbackService.DeleteReportAsync(reportId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Xóa báo cáo thành công."
			});
		}
	}
}