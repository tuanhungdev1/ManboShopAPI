using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
