using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BannerDtos;
using ManboShopAPI.Domain.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class BannerController : ControllerBase
	{
		private readonly IBannerService _bannerService;

		public BannerController(IBannerService bannerService)
		{
			_bannerService = bannerService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<BannerDto>>> GetAllBanners([FromQuery] BannerRequestParameters bannerRequestParameters)
		{
			var (banners, metaData) = await _bannerService.GetAllBannersAsync(bannerRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy dữ liệu danh sách banner thành công.",
				Data = banners,
				Pagination = metaData
			});
		}

		[HttpGet("active")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<BannerDto>>> GetActiveBanners()
		{
			var banners = await _bannerService.GetActiveBannersAsync();
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy dữ liệu danh sách banner đang hoạt động thành công.",
				Data = banners
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetBanner))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<BannerDto>> GetBanner(int id)
		{
			var banner = await _bannerService.GetBannerByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu banner với Id {id} thành công.",
				Data = banner
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateBanner([FromForm] BannerForCreateDto bannerDto)
		{
			await _bannerService.CreateBannerAsync(bannerDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới một banner thành công.",
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateBanner(
			int id,
			[FromForm] BannerForUpdateDto bannerDto)
		{
			await _bannerService.UpdateBannerAsync(id, bannerDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật dữ liệu banner với Id {id} thành công.",
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteBanner(int id)
		{
			await _bannerService.DeleteBannerAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa banner với Id {id} thành công.",
			});
		}
	}
}