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
			// Kiểm tra nếu người dùng vừa đăng nhập
			if (context.User.Identity.IsAuthenticated)
			{
				var sessionId = sessionService.GetOrCreateSessionId(context);
				var userId = int.Parse(context.User.FindFirst(ClaimTypes.NameIdentifier).Value);

				// Gộp giỏ hàng session vào giỏ hàng người dùng
				await cartService.MergeSessionCartToUserCart(sessionId, userId);

				// Xóa session ID cũ
				sessionService.ClearSessionId(context);
			}

			await _next(context);
		}
	}

	// Extension method để đăng ký middleware
	public static class CartSessionMiddlewareExtensions
	{
		public static IApplicationBuilder UseCartSession(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<CartSessionMiddleware>();
		}
	}
}
