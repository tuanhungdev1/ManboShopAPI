using ManboShopAPI.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
