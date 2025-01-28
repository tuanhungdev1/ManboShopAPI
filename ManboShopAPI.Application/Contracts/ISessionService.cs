using Microsoft.AspNetCore.Http;

namespace ManboShopAPI.Application.Contracts
{
	public interface ISessionService
	{
		string GetOrCreateSessionId(HttpContext context);
		void StoreSessionId(HttpContext context, string sessionId);
		void ClearSessionId(HttpContext context);
	}
}
