using ManboShopAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			//services.AddScoped<IUserRepository, UserRepository>();
			//services.AddScoped<IAddressRepository, AddressRepository>();
			//services.AddScoped<IProductRepository, ProductRepository>();
			//services.AddScoped<IWishlistRepository, WishlistRepository>();
			//services.AddScoped<ICartRepository, CartRepository>();
			//services.AddScoped<ICategoryRepository, CategoryRepository>();
			//services.AddScoped<IBrandRepository, BrandRepository>();
			//services.AddScoped<ISupplierRepository, SupplierRepository>();


			//Đăng Kí Unit Of Work
			//services.AddScoped<IUnitOfWork, UnitOfWork>();


			return services;
		}
	}
}
