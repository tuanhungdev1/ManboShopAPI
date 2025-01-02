using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class ProductAttributeValueConfiguration : IEntityTypeConfiguration<ProductAttributeValue>
	{
		public void Configure(EntityTypeBuilder<ProductAttributeValue> builder)
		{

			builder.HasOne(pav => pav.Product)
				.WithMany(p => p.ProductAttributeValues)
				.HasForeignKey(pav => pav.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			builder.HasOne(pav => pav.Attribute)
				.WithMany(a => a.ProductAttributeValues)
				.HasForeignKey(pav => pav.AttributeId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

		}
	}
}
