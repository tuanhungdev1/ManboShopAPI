namespace ManboShopAPI.Application.Interfaces
{
	public interface ILoggerService
	{
		void LogInfo(string message);
		void LogWarning(string message);
		void LogError(string message);
		void LogError(string message, Exception exception);
	}
}
