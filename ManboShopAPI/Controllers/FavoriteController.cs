using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace ManboShopAPI.Controllers
{
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

		[HttpGet("user/{userId}/products")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetUserFavoriteProducts(int userId)
		{
			var products = await _favoriteService.GetUserFavoriteProductsAsync(userId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách sản phẩm yêu thích cho người dùng với ID {userId} thành công.",
				Data = products
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddFavorite([FromBody] FavoriteForCreateDto favoriteForCreateDto)
		{
			await _favoriteService.AddFavoriteAsync(favoriteForCreateDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = $"Thêm sản phẩm với ID {favoriteForCreateDto.ProductId} vào danh sách yêu thích của người dùng với ID {favoriteForCreateDto.UserId} thành công."
			});
		}

		[HttpDelete("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> RemoveFavorite(int id)
		{
			await _favoriteService.RemoveFavoriteAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa sản phẩm yêu thích với ID {id} thành công."
			});
		}
	}
}