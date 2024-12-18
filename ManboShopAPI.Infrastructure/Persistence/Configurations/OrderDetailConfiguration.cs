using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


			builder.HasOne(o => o.Product)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(p => p.OrderId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(o => o.Coupon)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(p => p.CouponId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
