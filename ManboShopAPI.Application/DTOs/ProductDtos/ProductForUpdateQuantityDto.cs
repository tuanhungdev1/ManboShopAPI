using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.ProductDtos
{
	public class ProductForUpdateQuantityDto
	{
		[Required(ErrorMessage = "Số lượng sản phẩm không được để trống")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng sản phẩm phải là số nguyên dương hoặc bằng 0")]
		public required int Quantity { get; set; }
	}
}
