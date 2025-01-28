using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.BannerDtos
{
	public class BannerForCreateDto
	{
		[Required(ErrorMessage = "Tên banner là bắt buộc")]
		[MaxLength(500, ErrorMessage = "Tên không được vượt quá 500 ký tự")]
		public required string Name { get; set; }

		[Required(ErrorMessage = "Hình ảnh banner là bắt buộc")]
		public required IFormFile BannerImage { get; set; }
	}
}
