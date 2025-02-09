using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class FeedbackLikeConfiguration : IEntityTypeConfiguration<FeedbackLike>
	{
		public void Configure(EntityTypeBuilder<FeedbackLike> builder)
		{

			builder.HasOne(fl => fl.User)
				.WithMany(u => u.FeedbackLikes)
				.HasForeignKey(fl => fl.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(a => a.Feedback)
				.WithMany(u => u.FeedbackLikes)
				.HasForeignKey(a => a.FeedbackId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasIndex(fl => new { fl.UserId, fl.FeedbackId }).IsUnique();
		}
	}
}
