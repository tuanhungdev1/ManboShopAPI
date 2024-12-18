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


	public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
	{
		public void Configure(EntityTypeBuilder<ProductImage> builder)
		{

			builder.HasOne(o => o.Product)
				.WithMany(u => u.ProductImages)
				.HasForeignKey(o => o.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
