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

	
	public class BannerDetailConfiguration : IEntityTypeConfiguration<BannerDetail>
	{
		public void Configure(EntityTypeBuilder<BannerDetail> builder)
		{

			builder.HasOne(bd => bd.Banner)
				.WithMany(b => b.BannerDetails)
				.HasForeignKey(bd => bd.BannerId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			builder.HasOne(bd => bd.Product)
				.WithMany(p => p.BannerDetails)
				.HasForeignKey(bd => bd.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
				
			
		}
	}
}
