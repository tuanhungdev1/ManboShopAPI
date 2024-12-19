using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.BrandDtos
{
	public class BrandDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string? ImageUrl { get; set; }
		//public ICollection<Product> Products { get; set; } = new List<Product>();
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
