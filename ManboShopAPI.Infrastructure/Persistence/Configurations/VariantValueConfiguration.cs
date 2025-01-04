using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{


	public class VariantValueConfiguration : IEntityTypeConfiguration<VariantValue>
	{
		public void Configure(EntityTypeBuilder<VariantValue> builder)
		{

			builder.HasOne(vv => vv.Variant)
				.WithMany(v => v.VariantValues)
				.HasForeignKey(vv => vv.VariantId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
