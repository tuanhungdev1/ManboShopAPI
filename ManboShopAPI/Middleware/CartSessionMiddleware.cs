using ManboShopAPI.Application.Contracts;
using System.Security.Claims;

namespace ManboShopAPI.Middleware
{
	public class CartSessionMiddleware
	{
		private readonly RequestDelegate _next;
		public CartSessionMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context, ICartService cartService, ISessionService sessionService)
		{
			var existingSessionId = sessionService.GetSessionId(context);
			var isAuthenticated = context.User.Identity.IsAuthenticated;

			if (isAuthenticated)
			{
				if (!string.IsNullOrEmpty(existingSessionId))
				{
					// Merge giỏ hàng session vào user cart
					var userId = int.Parse(context.User.FindFirst(ClaimTypes.NameIdentifier).Value);
					await cartService.MergeSessionCartToUserCart(existingSessionId, userId);
					sessionService.ClearSessionId(context);
				}
			}
			//else
			//{
			//	// Kiểm tra nếu chưa có SessionId, tạo mới cho user ẩn danh ngay khi họ vào hệ thống
			//	if (string.IsNullOrEmpty(existingSessionId))
			//	{
			//		string sessionId = await sessionService.CreateNewSessionId(context);

			//		// 🔥 Kiểm tra xem giỏ hàng với SessionId đã tồn tại chưa
			//		var cartExists = await cartService.DoesCartExistAsync(sessionId);
			//		if (!cartExists)
			//		{
			//			var cart = new CartForCreateDto
			//			{
			//				SessionId = sessionId,
			//			};

			//			await cartService.CreateCartAsync(cart);
			//		}
			//	}
			//}

			await _next(context);
		}

	}

	public static class CartSessionMiddlewareExtensions
	{
		public static IApplicationBuilder UseCartSession(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<CartSessionMiddleware>();
		}
	}
}