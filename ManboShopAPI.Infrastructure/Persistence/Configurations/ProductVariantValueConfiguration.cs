using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class ProductVariantValueConfiguration : IEntityTypeConfiguration<ProductVariantValue>
	{
		public void Configure(EntityTypeBuilder<ProductVariantValue> builder)
		{

			builder.HasOne(pvv => pvv.Product)
				.WithMany(p => p.ProductVariantValues)
				.HasForeignKey(pvv => pvv.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
