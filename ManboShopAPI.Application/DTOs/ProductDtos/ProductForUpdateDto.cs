using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.ProductDtos
{
	public class ProductForUpdateDto
	{
		[Required]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public required string Name { get; set; }

		[Required]
		[MaxLength(1000)]
		public required string Description { get; set; }

		public string? Specification { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		public decimal Price { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		public decimal OldPrice { get; set; }

		[Required]
		[Range(0, int.MaxValue)]
		public int Quantity { get; set; }

		public int? CategoryId { get; set; }

		public int? BrandId { get; set; }

		public List<string> ImageUrls { get; set; } = new List<string>();
	}
}
