using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BannerDetailDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class BannerDetailsController : ControllerBase
	{
		private readonly IBannerDetailService _bannerDetailService;

		public BannerDetailsController(IBannerDetailService bannerDetailService)
		{
			_bannerDetailService = bannerDetailService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<BannerDetailDto>>> GetBannerDetails()
		{
			var bannerDetails = await _bannerDetailService.GetAllBannerDetailAsync();
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách chi tiết banner thành công.",
				Data = bannerDetails
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetBannerDetail))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<BannerDetailDto>> GetBannerDetail(int id)
		{
			var bannerDetail = await _bannerDetailService.GetBannerDetailByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin chi tiết banner với Id {id} thành công.",
				Data = bannerDetail
			});
		}

		[HttpGet("banner/{bannerId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<BannerDetailDto>>> GetBannerDetailsByBanner(int bannerId)
		{
			var bannerDetails = await _bannerDetailService.GetBannerDetailsByBannerIdAsync(bannerId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách chi tiết banner theo banner Id {bannerId} thành công.",
				Data = bannerDetails
			});
		}

		[HttpGet("product/{productId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<BannerDetailDto>>> GetBannerDetailsByProduct(int productId)
		{
			var bannerDetails = await _bannerDetailService.GetBannerDetailsByProductIdAsync(productId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách chi tiết banner theo sản phẩm Id {productId} thành công.",
				Data = bannerDetails
			});
		}

		[HttpGet("banner/{bannerId:int}/product/{productId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<BannerDetailDto>> GetBannerDetail(int bannerId, int productId)
		{
			var bannerDetail = await _bannerDetailService.GetBannerDetailAsync(bannerId, productId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy chi tiết banner thành công.",
				Data = bannerDetail
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateBannerDetail([FromBody] BannerDetailForCreateDto bannerDetailDto)
		{
			await _bannerDetailService.CreateBannerDetailAsync(bannerDetailDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới chi tiết banner thành công.",
				Data = bannerDetailDto
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateBannerDetail(
			int id,
			[FromBody] BannerDetailForUpdateDto bannerDetailDto)
		{
			await _bannerDetailService.UpdateBannerDetailAsync(id, bannerDetailDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật chi tiết banner với Id {id} thành công.",
				Data = bannerDetailDto
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteBannerDetail(int id)
		{
			await _bannerDetailService.DeleteBannerDetailAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa chi tiết banner với Id {id} thành công."
			});
		}
	}
}