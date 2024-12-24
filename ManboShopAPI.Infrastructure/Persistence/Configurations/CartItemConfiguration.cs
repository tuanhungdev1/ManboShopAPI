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

	public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
	{
		public void Configure(EntityTypeBuilder<CartItem> builder)
		{

			builder.HasOne(ci => ci.Product)
				.WithMany(p => p.CartItems)
				.HasForeignKey(bd => bd.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			builder.HasOne(ci => ci.Cart)
				.WithMany(c => c.CartItems)
				.HasForeignKey(ci => ci.CartId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
