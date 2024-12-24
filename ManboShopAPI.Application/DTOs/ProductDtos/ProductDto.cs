using ManboShopAPI.Application.DTOs.ProductImageDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.ProductDtos
{
	public class ProductDto
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string? Specification { get; set; }
		public decimal Price { get; set; }
		public decimal OldPrice { get; set; }
		public int BuyTurn { get; set; }
		public int Quantity { get; set; }
		public int? CategoryId { get; set; }
		public int? BrandId { get; set; }
		public string? CategoryName { get; set; }
		public string? BrandName { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public ICollection<ProductImageDto> ProductImages { get; set; }
	}
}
