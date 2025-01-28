using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class CartItemForUpdateDto
	{
		[Required(ErrorMessage = "Mã sản phẩm là bắt buộc.")]
		public int ProductId { get; set; }
		[Required(ErrorMessage = "Số lượng sản phẩm là bắt buộc.")]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity phải lớn hơn 0.")]
		public int Quantity { get; set; }
	}
}
