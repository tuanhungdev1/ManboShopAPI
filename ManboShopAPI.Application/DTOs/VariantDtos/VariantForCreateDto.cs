using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantForCreateDto
	{
        [Required(ErrorMessage = "Tên biến thể là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Tên biến thể không được vượt quá 100 ký tự.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Tệp là bắt buộc.")]
		public IFormFile file { get; set; }

		[Required(ErrorMessage = "Danh sách giá trị là bắt buộc.")]
		public List<string> Values { get; set; } = new List<string>();
	}
}
