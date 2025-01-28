using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class FavoriteController : ControllerBase
	{
		private readonly IFavoriteService _favoriteService;

		public FavoriteController(IFavoriteService favoriteService)
		{
			_favoriteService = favoriteService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetUserFavoriteProducts()
		{
			var products = await _favoriteService.GetUserFavoriteProductsAsync(User);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách sản phẩm yêu thích cho người dùng thành công.",
				Data = products
			});
		}

		[HttpGet("count")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<int>> GetCountFavoriteForCurrentUser()
		{
			var count = await _favoriteService.GetCountFavoriteForCurrentUser(User);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy số lượng sản phẩm yêu thích của người dùng hiện tại thành công.",
				Data = count
			});
		}

		
		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddFavorite([FromBody] FavoriteForCreateDto favoriteForCreateDto)
		{
			await _favoriteService.AddFavoriteAsync(User, favoriteForCreateDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = $"Thêm sản phẩm vào danh sách yêu thích của người dùng thành công."
			});
		}

		[HttpDelete]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> RemoveFavorite([FromBody] FavoriteForCreateDto favoriteForCreateDto)
		{
			await _favoriteService.RemoveFavoriteAsync(User, favoriteForCreateDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa sản phẩm trong danh sách yêu thích thành công."
			});
		}
	}
}