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
			if (context.Request.Path.StartsWithSegments("/api/Cart") ||
				context.Request.Path.StartsWithSegments("/Cart"))
			{
				var existingSessionId = sessionService.GetSessionId(context); // Phương thức mới chỉ để lấy sessionId hiện có
				var isAuthenticated = context.User.Identity.IsAuthenticated;

				if (isAuthenticated)
				{
					if (!string.IsNullOrEmpty(existingSessionId))
					{
						// Người dùng đã đăng nhập và có session ID -> thực hiện merge
						var userId = int.Parse(context.User.FindFirst(ClaimTypes.NameIdentifier).Value);
						await cartService.MergeSessionCartToUserCart(existingSessionId, userId);
						sessionService.ClearSessionId(context);
					}
					// Nếu không có existingSessionId thì không cần làm gì, 
					// vì người dùng đã đăng nhập sẽ sử dụng cart dựa trên userId
				}
				else
				{
					if (string.IsNullOrEmpty(existingSessionId))
					{
						// Chưa có session ID và chưa đăng nhập -> tạo mới session ID
						sessionService.CreateNewSessionId(context);
					}
					// Nếu đã có existingSessionId thì giữ nguyên để tiếp tục sử dụng
				}
			}

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