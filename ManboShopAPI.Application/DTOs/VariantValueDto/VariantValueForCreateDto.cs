using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantValueDto
{
	public class VariantValueForCreateDto
	{
		[Required(ErrorMessage = "Biến thể kết hợp là bắt buộc.")]
		public List<string> VariantCombination { get; set; } = new List<string>();

		[Required(ErrorMessage = "Gía mới biến thể kết hợp là bắt buộc.")]
		[Range(0, double.MaxValue, ErrorMessage = "Giá phải là một số dương.")]
		public decimal Price { get; set; }
		[Required(ErrorMessage = "Gía cũ biến thể kết hợp là bắt buộc.")]

		[Range(0, double.MaxValue, ErrorMessage = "Giá cũ phải là một số dương.")]
		public decimal OldPrice { get; set; }
		[Required(ErrorMessage = "Số lượng Biến thể kết hợp là bắt buộc.")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho phải là một số nguyên dương.")]
		public int Stock { get; set; }
	}
}
