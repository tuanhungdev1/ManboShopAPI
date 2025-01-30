using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class CartItemController : ControllerBase
	{
		private readonly ICartItemService _cartItemService;

		public CartItemController(ICartItemService cartItemService)
		{
			_cartItemService = cartItemService;
		}

		//[HttpGet("cart/{cartId:int}")]
		//[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status404NotFound)]
		//public async Task<ActionResult<IEnumerable<CartItemDto>>> GetCartItems(int cartId)
		//{
		//	var cartItems = await _cartItemService.GetCartItemsByCartIdAsync(cartId);
		//	return Ok(new ApiResponse<object>
		//	{
		//		StatusCode = 200,
		//		Success = true,
		//		Message = $"Lấy danh sách sản phẩm trong giỏ hàng {cartId} thành công.",
		//		Data = cartItems
		//	});
		//}

		//[HttpPut("{cartItemId:int}/quantity")]
		//[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status404NotFound)]
		//[ProducesResponseType(StatusCodes.Status400BadRequest)]
		//public async Task<IActionResult> UpdateCartItemQuantity(int cartItemId, [FromBody] UpdateCartItemQuantityDto updateCartItemQuantityDto)
		//{
		//	await _cartItemService.UpdateCartItemQuantityAsync(cartItemId, updateCartItemQuantityDto.Quantity);
		//	return Ok(new ApiResponse<object>
		//	{
		//		StatusCode = 200,
		//		Success = true,
		//		Message = "Cập nhật số lượng sản phẩm trong giỏ hàng thành công."
		//	});
		//}

		//[HttpDelete("cart/{cartId:int}/product/{productId:int}")]
		//[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status404NotFound)]
		//public async Task<IActionResult> RemoveCartItem(int cartId, int productId)
		//{
		//	await _cartItemService.RemoveCartItemAsync(cartId, productId);
		//	return Ok(new ApiResponse<object>
		//	{
		//		StatusCode = 200,
		//		Success = true,
		//		Message = "Xóa sản phẩm khỏi giỏ hàng thành công."
		//	});
		//}

		//[HttpGet("{cartItemId:int}/subtotal")]
		//[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status404NotFound)]
		//public async Task<ActionResult<decimal>> GetCartItemSubtotal(int cartItemId)
		//{
		//	var subtotal = await _cartItemService.GetCartItemSubtotalAsync(cartItemId);
		//	return Ok(new ApiResponse<object>
		//	{
		//		StatusCode = 200,
		//		Success = true,
		//		Message = "Tính tổng giá trị sản phẩm trong giỏ hàng thành công.",
		//		Data = subtotal
		//	});
		//}

		//[HttpPut("bulk-update")]
		//[ProducesResponseType(StatusCodes.Status200OK)]
		//[ProducesResponseType(StatusCodes.Status400BadRequest)]
		//public async Task<IActionResult> BulkUpdateQuantities([FromBody] IEnumerable<(int CartItemId, int NewQuantity)> updates)
		//{
		//	await _cartItemService.BulkUpdateQuantitiesAsync(updates);
		//	return Ok(new ApiResponse<object>
		//	{
		//		StatusCode = 200,
		//		Success = true,
		//		Message = "Cập nhật số lượng hàng loạt thành công."
		//	});
		//}
	}
}