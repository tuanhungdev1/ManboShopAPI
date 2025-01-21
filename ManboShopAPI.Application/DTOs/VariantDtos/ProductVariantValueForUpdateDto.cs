using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class ProductVariantValueForUpdateDto
	{
		[Required(ErrorMessage = "Giá biến thể không được để trống")]
		[Range(0, double.MaxValue, ErrorMessage = "Giá biến thể phải lớn hơn hoặc bằng 0")]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "Giá cũ của biến thể không được để trống")]
		[Range(0, double.MaxValue, ErrorMessage = "Giá cũ của biến thể phải lớn hơn hoặc bằng 0")]
		public decimal OldPrice { get; set; }

		[Required(ErrorMessage = "Số lượng tồn kho không được để trống")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn kho phải lớn hơn hoặc bằng 0")]
		public int Stock { get; set; }

		[Required(ErrorMessage = "Danh sách giá trị biến thể không được để trống")]
		public ICollection<string> VariantCombination { get; set; } = new List<string>();
	}
}
