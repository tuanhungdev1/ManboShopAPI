﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class News : BaseEntity
	{
		[Required]
		[MaxLength(300)]
        public required string Title { get; set; }
		[Required]
        public required string ImageUrl { get; set; }
		[Required]
        public required string Content { get; set; }
        public ICollection<NewsDetail> NewsDetails { get; set; } = new List<NewsDetail>();
    }
}