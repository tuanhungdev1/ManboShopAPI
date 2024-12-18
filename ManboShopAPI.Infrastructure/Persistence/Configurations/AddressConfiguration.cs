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
	public class AddressConfiguration : IEntityTypeConfiguration<Address>
	{
		public void Configure(EntityTypeBuilder<Address> builder)
		{

			builder.HasOne(a => a.User)
				.WithMany(u => u.Addresses)
				.HasForeignKey(a => a.UserId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade); 
		}
	}
}
