using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class CartItemDto
	{
		public int Id { get; set; }
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public int ProductVariantValueId { get; set; }
		public string ProductName { get; set; }
		public string ProductVariantSku { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}
