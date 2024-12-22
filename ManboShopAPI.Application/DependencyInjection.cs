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
			services.AddScoped<IBrandService, BrandService>();
			services.AddScoped<IOrderService, OrderService>();
			services.AddScoped<IFavoriteService, FavoriteService>();
			services.AddScoped<INewsService, NewsService>();
			services.AddScoped<INewsDetailService, NewsDetailService>();
			services.AddScoped<IBannerService, BannerService>();
			services.AddScoped<IBannerDetailService, BannerDetailService>();
			// Đăng ký AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			
			// Đăng ký Validators
			services.AddHttpContextAccessor();

			return services;
		}
	}
}
