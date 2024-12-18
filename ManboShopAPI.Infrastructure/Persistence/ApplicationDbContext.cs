using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.ConfigureWarnings(warnings => warnings
					.Ignore(RelationalEventId.PendingModelChangesWarning));
		}

		public DbSet<Category> Categories { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<BannerDetail> BannerDetails { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<NewsDetail> NewsDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<CouponCondition> CouponConditions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new RoleConfiguration());

			modelBuilder.ApplyConfiguration(new ProductConfiguration());

			modelBuilder.ApplyConfiguration(new CategoryConfiguration());

			modelBuilder.ApplyConfiguration(new UserConfiguration());

			modelBuilder.ApplyConfiguration(new BrandConfiguration());

			modelBuilder.ApplyConfiguration(new AddressConfiguration());

			modelBuilder.ApplyConfiguration(new BannerDetailConfiguration());

			modelBuilder.ApplyConfiguration(new CouponConditionConfiguration());

			modelBuilder.ApplyConfiguration(new FavoriteConfiguration());

			modelBuilder.ApplyConfiguration(new FeedbackConfiguration());

			modelBuilder.ApplyConfiguration(new NewsDetailConfiguration());

			modelBuilder.ApplyConfiguration(new OrderConfiguration());

			modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

			modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

		}
	}
}
