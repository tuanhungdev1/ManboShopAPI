using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.Services;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

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
			services.AddScoped<ICloudinaryService, CloudinaryService>();
			services.AddScoped<ICartService, CartService>();
			services.AddScoped<ICartItemService, CartItemService>();
			services.AddScoped<IAuthService, AuthService>();
			services.AddScoped<IFeedbackService, FeedbackService>();
			services.AddScoped<IEmailSender, EmailSender>();
			services.AddScoped<IVerificationService, VerificationService>();
			// Đăng ký AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			
			// Đăng ký Validators
			services.AddHttpContextAccessor();

			return services;
		}
	}
}
