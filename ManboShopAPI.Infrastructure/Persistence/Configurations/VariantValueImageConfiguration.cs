using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Application.Services;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class VariantValueImageConfiguration : IEntityTypeConfiguration<VariantValueImage>
	{
		public void Configure(EntityTypeBuilder<VariantValueImage> builder)
		{

			builder.HasOne(a => a.VariantValue)
				.WithMany(u => u.VariantValueImages)
				.HasForeignKey(a => a.VariantValueId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
