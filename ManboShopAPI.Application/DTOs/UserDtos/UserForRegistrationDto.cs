using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserForRegistrationDto
	{
		[MaxLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự.")]
		[Required(ErrorMessage = "Tên là bắt buộc.")]
		public string FirstName { get; set; }

		[MaxLength(100, ErrorMessage = "Họ không được vượt quá 100 ký tự.")]
		[Required(ErrorMessage = "Họ là bắt buộc.")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Tên người dùng là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Email là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Email không được vượt quá 100 ký tự.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Mật khẩu không được vượt quá 100 ký tự.")]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "Xác nhận mật khẩu không khớp.")]
		[MaxLength(100, ErrorMessage = "Xác nhận mật khẩu không được vượt quá 100 ký tự.")]
		[Required(ErrorMessage = "Xác nhận mật khẩu là bắt buộc.")]
		public string ConfirmPassword { get; set; }
	}
}