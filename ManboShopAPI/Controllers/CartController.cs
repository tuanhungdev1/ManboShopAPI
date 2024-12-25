using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Domain.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class CartController : ControllerBase
	{
		private readonly ICartService _cartService;

		public CartController(ICartService cartService)
		{
			_cartService = cartService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<CartDto>>> GetAllCarts(
			[FromQuery] CartRequestParameters cartRequestParameters)
		{
			var (carts, metaData) = await _cartService.GetAllCartAsync(cartRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách giỏ hàng thành công.",
				Data = carts,
				Pagination = metaData
			});
		}

		[HttpGet("session/{sessionId}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CartDto>> GetCartBySessionId(string sessionId)
		{
			var cart = await _cartService.GetCartBySessionIdAsync(sessionId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin giỏ hàng với SessionId {sessionId} thành công.",
				Data = cart
			});
		}

		[HttpGet("user/{userId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CartDto>> GetCartByUserId(int userId)
		{
			var cart = await _cartService.GetCartByUserIdAsync(userId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin giỏ hàng của người dùng {userId} thành công.",
				Data = cart
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateCart([FromBody] CartForCreateDto cartDto)
		{
			var cart = await _cartService.CreateCartAsync(cartDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo giỏ hàng mới thành công.",
				Data = cart
			});
		}

		[HttpPost("{cartId:int}/clear")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> ClearCart(int cartId)
		{
			await _cartService.ClearCartAsync(cartId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa tất cả sản phẩm trong giỏ hàng {cartId} thành công."
			});
		}

		[HttpPost("merge")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> MergeCarts(int sourceCartId, int destinationCartId)
		{
			await _cartService.MergeCartsAsync(sourceCartId, destinationCartId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Gộp giỏ hàng thành công."
			});
		}

		[HttpGet("{cartId:int}/total")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<decimal>> GetCartTotal(int cartId)
		{
			var total = await _cartService.GetCartTotalAsync(cartId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy tổng giá trị giỏ hàng {cartId} thành công.",
				Data = total
			});
		}

		[HttpGet("{cartId:int}/items-count")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<int>> GetCartItemsCount(int cartId)
		{
			var count = await _cartService.GetCartItemsCountAsync(cartId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy số lượng sản phẩm trong giỏ hàng {cartId} thành công.",
				Data = count
			});
		}

		[HttpPut("{cartId:int}/assign-user/{userId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> AssignCartToUser(int cartId, int userId)
		{
			await _cartService.AssignCartToUserAsync(cartId, userId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Gán giỏ hàng cho người dùng thành công."
			});
		}

		[HttpPut("{cartId:int}/update-session")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateCartSession(int cartId, [FromBody] string newSessionId)
		{
			await _cartService.UpdateCartSessionAsync(cartId, newSessionId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật SessionId mới cho giỏ hàng thành công."
			});
		}

		[HttpPost("{cartId:int}/checkout")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<OrderDto>> CheckoutCart(int cartId, [FromBody] OrderForCreateDto orderForCreateDto)
		{
			var order = await _cartService.CheckoutCart(cartId, orderForCreateDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Đặt hàng thành công.",
				Data = order
			});
		}
	}
}