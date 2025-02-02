using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class FeedbackLikeConfiguration : IEntityTypeConfiguration<FeedbackLike>
	{
		public void Configure(EntityTypeBuilder<FeedbackLike> builder)
		{

			builder.HasOne(a => a.User)
				.WithMany(u => u.FeedbackLikes)
				.HasForeignKey(a => a.UserId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(a => a.Feedback)
				.WithMany(u => u.FeedbackLikes)
				.HasForeignKey(a => a.FeedbackId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
