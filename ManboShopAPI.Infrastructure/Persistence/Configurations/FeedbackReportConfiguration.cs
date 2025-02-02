using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class FeedbackReportConfiguration : IEntityTypeConfiguration<FeedbackReport>
	{
		public void Configure(EntityTypeBuilder<FeedbackReport> builder)
		{

			builder.HasOne(a => a.User)
				.WithMany(u => u.FeedbackReports)
				.HasForeignKey(a => a.UserId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(a => a.Feedback)
				.WithMany(u => u.FeedbackReports)
				.HasForeignKey(a => a.FeedbackId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.NoAction);
		}
	}
}
