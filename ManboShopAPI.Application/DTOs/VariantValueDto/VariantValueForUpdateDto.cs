using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantValueDto
{
	public class VariantValueForUpdateDto
	{
		[Required(ErrorMessage = "Giá trị biến thể không được để trống")]
		public string Value { get; set; }

		public IFormFile? FileImage { get; set; }
	}
}
