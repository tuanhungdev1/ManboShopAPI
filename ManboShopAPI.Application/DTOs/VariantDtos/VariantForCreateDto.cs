
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantForCreateDto
	{
        [Required(ErrorMessage = "Tên biến thể là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Tên biến thể không được vượt quá 100 ký tự.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Danh sách giá trị là bắt buộc.")]
		public List<VariantItemDto> Values { get; set; } = new List<VariantItemDto>();
	}
}
