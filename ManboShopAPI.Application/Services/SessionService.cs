using ManboShopAPI.Application.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;

namespace ManboShopAPI.Application.Services
{
	public class SessionService : ISessionService
	{
		private const string CartSessionKey = "CartSessionId";
		private readonly IConfiguration _configuration;

		public SessionService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public string GetSessionId(HttpContext context)
		{
			return context.Request.Cookies[CartSessionKey];
		}

		public void CreateNewSessionId(HttpContext context)
		{
			var sessionId = Guid.NewGuid().ToString();
			var cookieOptions = new CookieOptions
			{
				HttpOnly = true,
				Secure = false,
				SameSite = SameSiteMode.Lax,
				Expires = DateTime.UtcNow.AddDays(30)
			};
			context.Response.Cookies.Append(CartSessionKey, sessionId, cookieOptions);
		}

		public void ClearSessionId(HttpContext context)
		{
			context.Response.Cookies.Delete(CartSessionKey);
		}
	}
}