using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Interfaces;
using ManboShopAPI.Infrastructure.Persistence;
using ManboShopAPI.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ManboShopAPI.Application.UnitOfWork;

namespace ManboShopAPI.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(configuration.GetConnectionString("ApplicationConnection"))
			);

			// Đăng Kí Repository
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IProductRepository, ProductRepository>();
			services.AddScoped<IBrandRepository, BrandRepository>();
			services.AddScoped<IOrderRepository, OrderRepository>();
			services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
			services.AddScoped<INewsDetailRepository, NewsDetailRepository>();
			services.AddScoped<IFavoriteRepository, FavoriteRepository>();
			services.AddScoped<INewsRepository, NewsRepository>();
			services.AddScoped<INewsDetailRepository, NewsDetailRepository>();
			services.AddScoped<IBannerRepository, BannerRepository>();
			services.AddScoped<IBannerDetailRepository, BannerDetailRepository>();
			services.AddScoped<IProductImageRepository, ProductImageRepository>();
			services.AddScoped<ICartRepository, CartRepository>();
			services.AddScoped<ICartItemRepository, CartItemRepository>();
			services.AddScoped<IFeedbackRepository, FeedbackRepository>();
			//Đăng Kí Unit Of Work
			services.AddScoped<IUnitOfWork, UnitOfWork>();


			return services;
		}
	}
}
