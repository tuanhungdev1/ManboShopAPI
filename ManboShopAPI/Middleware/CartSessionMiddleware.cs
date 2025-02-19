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

			// Nếu user đăng nhập và có session cart, merge vào user cart
			if (context.User.Identity.IsAuthenticated && !string.IsNullOrEmpty(existingSessionId))
			{
				try
				{
					var userId = int.Parse(context.User.FindFirst(ClaimTypes.NameIdentifier).Value);
					await cartService.MergeSessionCartToUserCart(existingSessionId, userId);
					sessionService.ClearSessionId(context);
				}
				catch (Exception)
				{
					// Log error nhưng không throw exception để không ảnh hưởng flow chính
				}
			}
			// Nếu chưa đăng nhập và chưa có session, tạo mới session
			else if (!context.User.Identity.IsAuthenticated && string.IsNullOrEmpty(existingSessionId))
			{
				await sessionService.CreateNewSessionId(context);
			}

			await _next(context);
		}
	}
}