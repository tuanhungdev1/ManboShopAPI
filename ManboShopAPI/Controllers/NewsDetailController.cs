using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.NewsDetailDto;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class NewsDetailController : ControllerBase
	{
		private readonly INewsDetailService _newsDetailService;

		public NewsDetailController(INewsDetailService newsDetailService)
		{
			_newsDetailService = newsDetailService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<NewsDetailDto>>> GetAllNewsDetails(
			[FromQuery] NewsDetailRequestParameters newsDetailRequestParameters)
		{
			var (newsDetails, metaData) = await _newsDetailService.GetAllNewsDetailAsync(newsDetailRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách chi tiết tin tức thành công.",
				Data = newsDetails,
				Pagination = metaData
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetNewsDetail))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<NewsDetailDto>> GetNewsDetail(int id)
		{
			var newsDetail = await _newsDetailService.GetNewsDetail(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy chi tiết tin tức với Id {id} thành công.",
				Data = newsDetail
			});
		}

		[HttpGet("news/{newsId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<NewsDetailDto>>> GetByNewsId(int newsId)
		{
			var newsDetails = await _newsDetailService.GetByNewsIdAsync(newsId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách chi tiết tin tức theo NewsId {newsId} thành công.",
				Data = newsDetails
			});
		}

		[HttpGet("product/{productId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<NewsDetailDto>>> GetByProductId(int productId)
		{
			var newsDetails = await _newsDetailService.GetByProductIdAsync(productId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách chi tiết tin tức theo ProductId {productId} thành công.",
				Data = newsDetails
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateNewsDetail([FromBody] NewsDetailForCreateDto newsDetailDto)
		{
			await _newsDetailService.CreateNewsDetailAsync(newsDetailDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới chi tiết tin tức thành công."
			});
		}

		[HttpPost("batch/{newsId:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddNewsDetails(int newsId, [FromBody] IEnumerable<int> productIds)
		{
			await _newsDetailService.AddNewsDetailsAsync(newsId, productIds);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = $"Thêm nhiều chi tiết tin tức cho NewsId {newsId} thành công."
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateNewsDetail(int id, [FromBody] NewsDetailForUpdateDto newsDetailDto)
		{
			await _newsDetailService.UpdateNewsDetailAsync(id, newsDetailDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật chi tiết tin tức với Id {id} thành công."
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteNewsDetail(int id)
		{
			await _newsDetailService.DeleteNewsDetailAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa chi tiết tin tức với Id {id} thành công."
			});
		}

		[HttpDelete("news/{newsId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> RemoveNewsDetails(int newsId)
		{
			await _newsDetailService.RemoveNewsDetailsAsync(newsId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa tất cả chi tiết tin tức của NewsId {newsId} thành công."
			});
		}
	}
}