using ManboShopAPI.Application.DTOs.CartItemDtos;

namespace ManboShopAPI.Application.DTOs.CartDtos
{
	public class CartDto
	{
        public int Id { get; set; }
        public string? SessionId { get; set; }
		public int? UserId { get; set; }
		public ICollection<CartItemDto> CartItems { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
