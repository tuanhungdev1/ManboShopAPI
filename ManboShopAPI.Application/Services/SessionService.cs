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
			context.Request.Cookies.TryGetValue(CartSessionKey, out var sessionId);
			return sessionId;
		}

		public async Task<string> CreateNewSessionId(HttpContext context)
		{
			var sessionId = Guid.NewGuid().ToString();
			var cookieOptions = new CookieOptions
			{
				HttpOnly = true,
				Secure = true,
				SameSite = SameSiteMode.None,
				Expires = DateTime.UtcNow.AddDays(30)
			};
			context.Response.Cookies.Append(CartSessionKey, sessionId, cookieOptions);
			return sessionId;
		}

		public void ClearSessionId(HttpContext context)
		{
			context.Response.Cookies.Delete(CartSessionKey);
		}
	}
}