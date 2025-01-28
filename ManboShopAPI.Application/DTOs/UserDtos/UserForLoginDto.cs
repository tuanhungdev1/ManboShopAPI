using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserForLoginDto
	{
		[Required(ErrorMessage = "Tên người dùng là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Tên người dùng không được vượt quá 100 ký tự.")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Mật khẩu không được vượt quá 100 ký tự.")]
		public string Password { get; set; }

		public bool IsRemember { get; set; }
	}
}