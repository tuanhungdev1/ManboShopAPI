using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.NewsDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class NewsController : ControllerBase
	{
		private readonly INewsService _newsService;

		public NewsController(INewsService newsService)
		{
			_newsService = newsService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<NewsDto>>> GetAllNews([FromQuery] NewsRequestParameters newsRequestParameters)
		{
			var (news, metaData) = await _newsService.GetAllNewsAsync(newsRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy dữ liệu danh sách các tin tức thành công.",
				Data = news,
				Pagination = metaData
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetNews))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<NewsDto>> GetNews(int id)
		{
			var news = await _newsService.GetNewsByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu tin tức với Id {id} thành công.",
				Data = news
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateNews(
			[FromBody] NewsForCreateDto newsDto)
		{
			await _newsService.CreateNewsAsync(newsDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới một tin tức thành công.",
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateNews(
			int id,
			[FromBody] NewsForUpdateDto newsDto)
		{
			await _newsService.UpdateNewsAsync(id, newsDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật dữ liệu tin tức với Id {id} thành công.",
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteNews(int id)
		{
			await _newsService.DeleteNewsAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa tin tức với Id {id} thành công.",
			});
		}

		[HttpGet("title/{title}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<NewsDto>> GetNewsByTitle(string title)
		{
			var news = await _newsService.GetNewsByTitleAsync(title);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu tin tức với tiêu đề {title} thành công.",
				Data = news
			});
		}
	}
}