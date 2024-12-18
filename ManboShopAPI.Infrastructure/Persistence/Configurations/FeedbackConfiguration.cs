using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	
	public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
	{
		public void Configure(EntityTypeBuilder<Feedback> builder)
		{

			builder.HasOne(a => a.User)
				.WithMany(u => u.Feedbacks)
				.HasForeignKey(a => a.UserId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(a => a.Product)
				.WithMany(p => p.Feedbacks)
				.HasForeignKey(a => a.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
