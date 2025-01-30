using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{


	public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
	{
		public void Configure(EntityTypeBuilder<OrderDetail> builder)
		{

			builder.HasOne(o => o.Order)
				.WithMany(u => u.OrderDetails)
				.HasForeignKey(o => o.OrderId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			builder.HasOne(o => o.ProductVariantValue)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(p => p.ProductVariantValueId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			

		}
	}
}
