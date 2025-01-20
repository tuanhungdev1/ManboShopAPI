using ManboShopAPI.Application.DTOs.AttributeDtos;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.DTOs.ProductImageDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Domain.Entities;
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
		public CategoryDto?	 Category { get; set; }
		public BrandDto? Brand { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public ICollection<ProductImageDto> ProductImages { get; set; } 
		public ICollection<ProductAttributeValueDto> Attributes { get; set; } 
        public ICollection<ProductVariantDto> Variants { get; set; }
        public ICollection<ProductVariantValueDto> VariantValues { get; set; }
    }
}
