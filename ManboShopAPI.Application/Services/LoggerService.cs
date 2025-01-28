﻿using ManboShopAPI.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace ManboShopAPI.Application.Services
{
	public class LoggerService : ILoggerService
	{
		private readonly ILogger<LoggerService> _logger;

		public LoggerService(ILogger<LoggerService> logger)
		{
			_logger = logger;
		}

		public void LogInfo(string message)
		{
			_logger.LogInformation($"[INFO] - {DateTime.Now} - {message}");
		}

		public void LogWarning(string message)
		{
			_logger.LogWarning($"[WARNING] - {DateTime.Now} - {message}");


		}

		public void LogError(string message)
		{
			_logger.LogError($"[ERROR] - {DateTime.Now} - {message}");
		}

		public void LogError(string message, Exception ex)
		{
			_logger.LogError(ex, $"[ERROR] - {DateTime.Now} - {message}");
		}
	}
}
