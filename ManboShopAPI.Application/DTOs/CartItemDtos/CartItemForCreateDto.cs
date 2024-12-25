using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class CartItemForCreateDto
	{
		[Required(ErrorMessage = "CartId là bắt buộc.")]
		public int CartId { get; set; }

		[Required(ErrorMessage = "ProductId là bắt buộc.")]
		public int ProductId { get; set; }

		[Required(ErrorMessage = "Quantity là bắt buộc.")]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity phải lớn hơn 0.")]
		public int Quantity { get; set; }
	}
}