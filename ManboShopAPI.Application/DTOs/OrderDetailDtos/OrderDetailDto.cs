using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.DTOs.OrderDetailDtos
{
	public class OrderDetailDto
	{
        public int Id { get; set; }
        public int Quantity { get; set; }
		public decimal Price { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public ProductDto Product { get; set; }
		public int? CouponId { get; set; }
		public Coupon? Coupon { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
