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

        public string GetOrCreateSessionId(HttpContext context)
        {
            var sessionId = context.Request.Cookies[CartSessionKey];

            if (string.IsNullOrEmpty(sessionId))
            {
                sessionId = Guid.NewGuid().ToString();
                StoreSessionId(context, sessionId);
            }

            return sessionId;
        }

        public void StoreSessionId(HttpContext context, string sessionId)
		{
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
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
