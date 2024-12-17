using Serilog.Events;
using Serilog;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.Services;

namespace ManboShopAPI.Extensions
{
	public static class LoggingExtensions
	{
		public static IServiceCollection AddLoggingServices(this IServiceCollection services, IConfiguration configuration)
		{
			
			Log.Logger = new LoggerConfiguration()
				.MinimumLevel.Information()
				.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
				.Enrich.FromLogContext()
				.WriteTo.Console(outputTemplate:
					"[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
				.WriteTo.File("Logs/log-.txt",
					rollingInterval: RollingInterval.Day,
					outputTemplate:
					"{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
				.CreateLogger();

			services.AddScoped<ILoggerService, LoggerService>();

			return services;
		}
	}
}
