using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class CartConfiguration : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{

			builder.HasOne(c => c.User)
				.WithMany()
				.HasForeignKey(bd => bd.UserId)
				.IsRequired(false)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
