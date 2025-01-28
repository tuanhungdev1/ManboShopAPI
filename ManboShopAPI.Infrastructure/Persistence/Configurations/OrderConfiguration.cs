using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class OrderConfiguration : IEntityTypeConfiguration<Order>
	{
		public void Configure(EntityTypeBuilder<Order> builder)
		{

			builder.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(o => o.Coupon)
				.WithMany(c => c.Orders)
				.HasForeignKey(o => o.CouponId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
