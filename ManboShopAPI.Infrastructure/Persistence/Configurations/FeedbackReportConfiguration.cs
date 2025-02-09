using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class FeedbackReportConfiguration : IEntityTypeConfiguration<FeedbackReport>
	{
		public void Configure(EntityTypeBuilder<FeedbackReport> builder)
		{

			
		}
	}
}
