using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class UpdateCartItemQuantityDto
	{
		[Required(ErrorMessage = "Số lượng cập nhật không thể trống")]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity phải lớn hơn 0.")]
		public int Quantity { get; set; }
	}
}
