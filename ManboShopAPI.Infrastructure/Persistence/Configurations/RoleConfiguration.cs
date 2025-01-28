using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<int>>
	{
		public void Configure(EntityTypeBuilder<IdentityRole<int>> builder)
		{
			builder.HasData(
				new IdentityRole<int> { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
				new IdentityRole<int> { Id = 2, Name = "Customer", NormalizedName = "CUSTOMER" }
			);
		}
	}
}
