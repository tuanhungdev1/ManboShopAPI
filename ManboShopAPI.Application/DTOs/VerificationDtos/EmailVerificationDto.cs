using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VerificationDtos
{
	public class EmailVerificationDto
	{
		[Required(ErrorMessage = "Email không được để trống.")]
		[EmailAddress(ErrorMessage = "Email không hợp lệ.")]
		public string Email { get; set; }
	}
}
