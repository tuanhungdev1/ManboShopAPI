using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VerificationDtos
{
	public class VerificationRequestDto
	{
		[Required(ErrorMessage = "Email không được để trống.")]
		[EmailAddress(ErrorMessage = "Email không hợp lệ.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Mã xác nhận không được để trống.")]
		public string Code { get; set; }
	}
}
