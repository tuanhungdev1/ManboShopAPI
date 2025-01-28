using ManboShopAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.BannerDtos
{
	public class BannerForUpdateDto
	{
		[Required(ErrorMessage = "Tên banner là bắt buộc")]
		[MaxLength(500, ErrorMessage = "Tên không được vượt quá 500 ký tự")]
		public string Name { get; set; }

		public IFormFile? BannerImage { get; set; }

		public BannerStatus Status { get; set; }
	}
}
