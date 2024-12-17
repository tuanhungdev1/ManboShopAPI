
using ManboShopAPI.Application;
using ManboShopAPI.Application.Common.Models;
using ManboShopAPI.Extensions;
using ManboShopAPI.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;

namespace ManboShopAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var _key = builder.Configuration["JwtSettings:SecurityKey"];
			var _issuer = builder.Configuration["JwtSettings:ValidIssuer"];
			var _audience = builder.Configuration["JwtSettings:ValidAudience"];
			var _expirtyMinutes = builder.Configuration["JwtSettings:TokenExpiryMinutes"];


			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Host.UseSerilog();
			//builder.Services.AddAutoMapper(typeof(MappingProfile));
			builder.Services
							.AddInfrastructureServices(builder.Configuration)
							.AddApplicationServices()
							.AddLoggingServices(builder.Configuration);

			//ServicesExtensions
			builder.Services.ConfigureIdentity();
			builder.Services.ConfigureIISIntegration();


			builder.Services.Configure<IISServerOptions>(options =>
			{
				options.MaxRequestBodySize = int.MaxValue; 
			});

			builder.Services.Configure<FormOptions>(options =>
			{
				options.MultipartBodyLengthLimit = int.MaxValue;
			});



			//CORS
			builder.Services.AddCors(c =>
			{
				c.AddPolicy("CorsPolicy", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader().WithExposedHeaders("X-Pagination"));
			});

			//Authentication và JwtBearer
			builder.Services.AddAuthentication(options =>
			{
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(options =>
			{
				options.RequireHttpsMetadata = false;
				options.SaveToken = true;
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_key)),
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidIssuer = _issuer,
					ValidAudience = _audience,
					ClockSkew = TimeSpan.Zero
				};

				options.Events = new JwtBearerEvents
				{
					OnChallenge = async context =>
					{
						context.HandleResponse();

						context.Response.StatusCode = 401;
						context.Response.ContentType = "application/json";

						var response = new
						{
							status = 401,
							message = "Unauthorized. Token is invalid or has expired.",
							error = "Unauthorized"
						};

						await context.Response.WriteAsJsonAsync(response);
					},
					OnAuthenticationFailed = context =>
					{
						if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
						{
							context.Response.Headers.Add("Token-Expired", "true");
						}
						return Task.CompletedTask;
					}
				};
			});

			builder.Services.ConfigureApplicationCookie(options =>
			{
				options.Events.OnRedirectToLogin = context =>
				{
					context.Response.StatusCode = StatusCodes.Status401Unauthorized;
					return Task.CompletedTask;
				};
			});

			builder.Configuration
								.SetBasePath(builder.Environment.ContentRootPath)
								.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
								.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
								.AddEnvironmentVariables();

			builder.Services.Configure<JwtSettings>(
														builder.Configuration.GetSection("JwtSettings"));

			builder.Services.Configure<CloudinarySettings>(
														builder.Configuration.GetSection("CloudinarySettings")
														);

			var app = builder.Build();
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}
			
			app.UseHttpsRedirection();
			app.UseCors("CorsPolicy");

			app.UseHttpsRedirection();
			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
