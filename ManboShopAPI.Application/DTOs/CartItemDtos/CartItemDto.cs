using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class CartItemDto
	{
        public int Id { get; set; }
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public ProductDto Product { get; set; }
		public int Quantity { get; set; }
		public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
