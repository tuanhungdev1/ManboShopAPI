using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{


	public class CouponConditionConfiguration : IEntityTypeConfiguration<CouponCondition>
	{
		public void Configure(EntityTypeBuilder<CouponCondition> builder)
		{

			builder.HasOne(o => o.Coupon)
				.WithMany(u => u.CouponConditions)
				.HasForeignKey(o => o.CouponId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			
		}
	}
}
