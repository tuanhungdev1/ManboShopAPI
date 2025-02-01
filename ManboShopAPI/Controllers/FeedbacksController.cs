using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.DTOs.FeedbackDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

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
		public async Task<ActionResult<IEnumerable<FeedbackDto>>> GetFeedbacksByProduct(int productId)
		{
			var feedbacks = await _feedbackService.GetFeedbacksByProductIdAsync(productId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách đánh giá của sản phẩm Id {productId} thành công.",
				Data = feedbacks
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
			return Ok(new ApiResponse<object>
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
			var feedback = await _feedbackService.CreateFeedbackAsync(feedbackForCreateDto);
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
	}
}