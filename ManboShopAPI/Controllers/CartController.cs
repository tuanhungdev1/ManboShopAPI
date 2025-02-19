using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
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
	public class CartController : ControllerBase
	{
		private readonly ICartService _cartService;
		private readonly ISessionService _sessionService;

		public CartController(ICartService cartService, ISessionService sessionService)
		{
			_cartService = cartService;
			_sessionService = sessionService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CartDto>> GetCart()
		{
			if (User.Identity.IsAuthenticated)
			{
				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var cart = await _cartService.GetOrCreateCartByUserAsync(userId);
				return Ok(new ApiResponse<object>
				{
					StatusCode = 200,
					Success = true,
					Message = "Lấy thông tin giỏ hàng thành công.",
					Data = cart
				});
			}

			var sessionId = _sessionService.GetSessionId(HttpContext);
			if (string.IsNullOrEmpty(sessionId))
			{
				sessionId = await _sessionService.CreateNewSessionId(HttpContext);
			}

			var sessionCart = await _cartService.GetOrCreateCartBySessionAsync(sessionId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy thông tin giỏ hàng thành công.",
				Data = sessionCart
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

		[HttpPost("merge-to-user/{userId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> MergeSessionCartToUserCart(int userId)
		{
			var sessionId = _sessionService.GetSessionId(HttpContext);
			if (!string.IsNullOrEmpty(sessionId))
			{
				await _cartService.MergeSessionCartToUserCart(sessionId, userId);
				_sessionService.ClearSessionId(HttpContext);
			}

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Gộp giỏ hàng session vào giỏ hàng người dùng thành công."
			});
		}

		[HttpPost("items")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<CartItemDto>> AddItemToCart([FromBody] CartItemForCreateDto cartItemDto)
		{
			CartItemDto cartItem;

			if (User.Identity.IsAuthenticated)
			{
				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var userCart = await _cartService.GetOrCreateCartByUserAsync(userId);
				cartItem = await _cartService.AddItemToCartAsync(userCart.Id, cartItemDto);
			}
			else
			{
				var sessionId = _sessionService.GetSessionId(HttpContext);
				var sessionCart = await _cartService.GetCartBySessionIdAsync(sessionId);
				cartItem = await _cartService.AddItemToCartAsync(sessionCart.Id, cartItemDto);
			}

			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Thêm sản phẩm vào giỏ hàng thành công.",
				Data = cartItem
			});
		}

		[HttpPut("items/{itemId:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<CartItemDto>> UpdateCartItem(int itemId, [FromBody] CartItemForUpdateDto cartItemDto)
		{
			CartItemDto cartItem;

			if (User.Identity.IsAuthenticated)
			{
				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var userCart = await _cartService.GetOrCreateCartByUserAsync(userId);
				cartItem = await _cartService.UpdateCartItemAsync(userCart.Id, itemId, cartItemDto);
			}
			else
			{
				var sessionId = _sessionService.GetSessionId(HttpContext);
				var sessionCart = await _cartService.GetCartBySessionIdAsync(sessionId);
				cartItem = await _cartService.UpdateCartItemAsync(sessionCart.Id, itemId, cartItemDto);
			}

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Cập nhật sản phẩm trong giỏ hàng thành công.",
				Data = cartItem
			});
		}

		[HttpDelete("items/{itemId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> RemoveCartItem(int itemId)
		{
			if (User.Identity.IsAuthenticated)
			{
				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var userCart = await _cartService.GetOrCreateCartByUserAsync(userId);
				await _cartService.RemoveCartItemAsync(userCart.Id, itemId);
			}
			else
			{
				var sessionId = _sessionService.GetSessionId(HttpContext);
				var sessionCart = await _cartService.GetCartBySessionIdAsync(sessionId);
				await _cartService.RemoveCartItemAsync(sessionCart.Id, itemId);
			}

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Xóa sản phẩm khỏi giỏ hàng thành công."
			});
		}

		[HttpPost("checkout")]
		[Authorize]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<OrderDto>> CheckoutCart([FromBody] OrderForCreateDto orderForCreateDto)
		{
			OrderDto order;
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			if (User.Identity.IsAuthenticated)
			{
				order = await _cartService.CheckoutCartAsync(userId, orderForCreateDto);
			}
			else
			{
				var sessionId = _sessionService.GetSessionId(HttpContext);
				order = await _cartService.CheckoutCartAsync(userId, orderForCreateDto);
				_sessionService.ClearSessionId(HttpContext);
			}

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Đặt hàng thành công.",
				Data = order
			});
		}

		[HttpPost("clear")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> ClearCart()
		{
			if (User.Identity.IsAuthenticated)
			{
				var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
				var userCart = await _cartService.GetOrCreateCartByUserAsync(userId);
				await _cartService.ClearCartAsync(userCart.Id);
			}
			else
			{
				var sessionId = _sessionService.GetSessionId(HttpContext);
				var sessionCart = await _cartService.GetCartBySessionIdAsync(sessionId);
				await _cartService.ClearCartAsync(sessionCart.Id);
			}

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Xóa tất cả sản phẩm trong giỏ hàng thành công."
			});
		}
	}
}