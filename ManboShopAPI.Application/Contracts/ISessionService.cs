using Microsoft.AspNetCore.Http;

namespace ManboShopAPI.Application.Contracts
{
	public interface ISessionService
	{
		string GetSessionId(HttpContext context);
		Task<string> CreateNewSessionId(HttpContext context);
		void ClearSessionId(HttpContext context);
	}
}
