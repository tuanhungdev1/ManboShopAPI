using ManboShopAPI.Application.Common.Models;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.Forbidden;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Exceptions.Unauthorized;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace ManboShopAPI.Middleware
{
	public static class ExceptionMiddlewareExtensions
	{
		public static void ConfigureExceptionHandler(this WebApplication app)
		{
			app.UseExceptionHandler(appError =>
			{
				appError.Run(async context =>
				{

					// Tạo scope để resolve service
					using var scope = app.Services.CreateScope();
					var logger = scope.ServiceProvider.GetRequiredService<ILoggerService>();
					context.Response.ContentType = "application/json";
					context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
					var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
					if (contextFeature != null)
					{
						context.Response.StatusCode = contextFeature.Error switch
						{
							NotFoundException => StatusCodes.Status404NotFound,
							BadRequestException => StatusCodes.Status400BadRequest,
							UnauthorizedException => StatusCodes.Status401Unauthorized,
							ForbiddenException => StatusCodes.Status403Forbidden,
							_ => StatusCodes.Status500InternalServerError
						};

						await context.Response.WriteAsync(new ErrorDetails()
						{
							StatusCode = context.Response.StatusCode,
							Message = contextFeature.Error.Message,
						}.ToString());
					}
				});
			});
		}
	}
}
