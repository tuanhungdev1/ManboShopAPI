using Bogus;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			// Cấu hình quan hệ như bạn đã định nghĩa
			builder.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId)
				.OnDelete(DeleteBehavior.SetNull)
				.IsRequired(false);

			builder.HasOne(p => p.Brand)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.BrandId)
				.OnDelete(DeleteBehavior.SetNull)
				.IsRequired(false);

		}
	}
}