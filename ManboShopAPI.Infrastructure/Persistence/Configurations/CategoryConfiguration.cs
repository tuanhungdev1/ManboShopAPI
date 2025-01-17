using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{

			builder
			.HasMany(c => c.SubCategories) 
			.WithOne(c => c.ParentCategory) 
			.HasForeignKey(c => c.ParentCategoryId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.NoAction);
		}

		
	}
}
