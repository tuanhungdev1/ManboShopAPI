﻿using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{

	public class NewsDetailConfiguration : IEntityTypeConfiguration<NewsDetail>
	{
		public void Configure(EntityTypeBuilder<NewsDetail> builder)
		{


			builder.HasOne(u => u.News)
				.WithMany(c => c.NewsDetails)
				.HasForeignKey(c => c.NewsId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(u => u.Product)
				.WithMany(r => r.NewsDetails)
				.HasForeignKey(r => r.ProductId)
				.IsRequired(true)
				.OnDelete(DeleteBehavior.Cascade);

		}
	}
}