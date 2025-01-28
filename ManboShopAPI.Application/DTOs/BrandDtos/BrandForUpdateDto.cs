using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.BrandDtos
{
	public class BrandForUpdateDto
	{
		[Required(ErrorMessage = "Tên thương hiệu không được để trống")]
		[MaxLength(100, ErrorMessage = "Tên thương hiệu không được vượt quá 100 ký tự")]
		public required string Name { get; set; }
		public string? ImageUrl { get; set; }
		
	}
}
