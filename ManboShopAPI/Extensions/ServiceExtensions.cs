using ManboShopAPI.Application.Mappings;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System.Reflection;

namespace ManboShopAPI.Extensions
{
	public static class ServiceExtensions
	{
		public static void ConfigureIISIntegration(this IServiceCollection services)
		{
			services.Configure<IISOptions>(options =>
			{
				options.AutomaticAuthentication = true;
				options.ForwardClientCertificate = true;
				options.AuthenticationDisplayName = "Windows";
			});
		}

		// Cấu hình Identity với thêm options
		public static void ConfigureIdentity(this IServiceCollection services)
		{
			services.AddIdentity<User, IdentityRole<int>>(o =>
			{
				// Password settings
				o.Password.RequireDigit = true;
				o.Password.RequireLowercase = true;
				o.Password.RequireUppercase = true;
				o.Password.RequireNonAlphanumeric = true;
				o.Password.RequiredLength = 10;

				// User settings
				o.User.RequireUniqueEmail = true;
				o.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

				// Lockout settings
				o.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
				o.Lockout.MaxFailedAccessAttempts = 5;
				o.Lockout.AllowedForNewUsers = true;

				// SignIn settings
				o.SignIn.RequireConfirmedEmail = false;
				o.SignIn.RequireConfirmedPhoneNumber = false;
			})
			.AddEntityFrameworkStores<ApplicationDbContext>()
			.AddDefaultTokenProviders()
			.AddRoles<IdentityRole<int>>();
		}

		// Cấu hình JSON Serializer
		public static void ConfigureJsonSerializerSettings(this IServiceCollection services)
		{
			services.AddControllers()
				.AddNewtonsoftJson(options =>
				{
					options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
					options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
					options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
					options.SerializerSettings.DateFormatString = "yyyy-MM-ddTHH:mm:ss.fffZ";
				});
		}


		
	}
}
