using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.Mappings;
using ManboShopAPI.Application.Services;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			// Đăng ký Services
			services.AddScoped<ICategoryService, CategoryService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IProductService, ProductService>();
			//services.AddScoped<ICategoryService, CategoryService>();
			//services.AddScoped<IAuthenticationService, AuthenticationService>();
			//services.AddScoped<ICloudinaryService, CloudinaryService>();
			services.AddScoped<IBrandService, BrandService>();
			//services.AddScoped<ISupplierService, SupplierService>();
			//services.AddScoped<IWishlistService, WishlistService>();


			// Đăng ký AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			
			// Đăng ký Validators
			services.AddHttpContextAccessor();

			return services;
		}
	}
}
