using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.UserDtos;

namespace ManboShopAPI.Application.DTOs.FeedbackDtos
{
	public class FeedbackDto
	{
        public int Id { get; set; }
        public string Content { get; set; }
		public int Star { get; set; }
		public int UserId { get; set; }
		public int ProductId { get; set; }
		public UserDto User { get; set; }
		public ProductDto Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
