using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.FeedbackDtos
{
	public class FeedbackForUpdateDto
	{
		[Required(ErrorMessage = "Content is required.")]
		[MaxLength(1000, ErrorMessage = "Content cannot exceed 1000 characters.")]
		public string Content { get; set; }

		[Range(0, 5, ErrorMessage = "Star rating must be between 0 and 5.")]
		[Required(ErrorMessage = "Star rating is required.")]
		public int Star { get; set; }

		[Required(ErrorMessage = "User ID is required.")]
		public int UserId { get; set; }

		[Required(ErrorMessage = "Product ID is required.")]
		public int ProductId { get; set; }
	}
}