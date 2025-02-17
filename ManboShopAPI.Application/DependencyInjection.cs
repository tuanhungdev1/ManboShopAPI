using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.DTOs.VariantValueDto;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.Mappings.MapperResolver;
using ManboShopAPI.Application.Services;
using ManboShopAPI.Domain.Entities;
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
			services.AddScoped<ISessionService, SessionService>();
			services.AddScoped<IAddressService, AddressService>();
			services.AddScoped<IDashboardService, DashboardService>();
			// Đăng ký AutoMapper
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			
			// Đăng ký Validators
			services.AddHttpContextAccessor();


			// Đăng ký Resolver
			services.AddScoped<IValueResolver<ProductVariantValue, ProductVariantValueDto, ICollection<ProductVariantDetailDto>>, VariantCombinationResolver>();
			services.AddScoped<IValueResolver<Product, ProductDto, ICollection<ProductVariantDto>>, ProductVariantsResolver>();
			return services;
		}
	}
}
