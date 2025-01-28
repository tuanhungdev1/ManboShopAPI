using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
	{
		public void Configure(EntityTypeBuilder<Favorite> builder)
		{

			builder.HasOne(bd => bd.User)
				.WithMany(b => b.Favorites)
				.HasForeignKey(bd => bd.UserId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


			builder.HasOne(bd => bd.Product)
				.WithMany(p => p.Favorites)
				.HasForeignKey(bd => bd.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);


		}
	}
}
