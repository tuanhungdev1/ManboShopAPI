
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;

namespace ManboShopAPI.Application.DTOs.OrderDetailDtos
{
	public class OrderDetailDto
	{
        public int Id { get; set; }
        public int Quantity { get; set; }
		public decimal Price { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public ProductVariantValueDto ProductVariantValue { get; set; }
		public ProductDto Product { get; set; }
		public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
