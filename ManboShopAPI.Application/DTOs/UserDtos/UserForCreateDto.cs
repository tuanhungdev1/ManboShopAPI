using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserForCreateDto
	{
		[Required(ErrorMessage = "Tên đăng nhập không được để trống")]
		[StringLength(100, MinimumLength = 3,
			ErrorMessage = "Tên đăng nhập phải có độ dài từ 3 đến 100 ký tự")]
		[RegularExpression(@"^[a-zA-Z0-9._@+-]+$",
			ErrorMessage = "Tên đăng nhập chỉ được chứa chữ cái, số và các ký tự đặc biệt (. _ @ + -)")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Email không được để trống")]
		[EmailAddress(ErrorMessage = "Email không đúng định dạng")]
		[StringLength(256, ErrorMessage = "Email không được vượt quá 256 ký tự")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Mật khẩu không được để trống")]
		[StringLength(100, MinimumLength = 6,
			ErrorMessage = "Mật khẩu phải có độ dài từ 6 đến 100 ký tự")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
			ErrorMessage = "Mật khẩu phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt")]
		public string Password { get; set; }

		[Compare("Password", ErrorMessage = "Mật khẩu xác nhận không khớp")]
		public string ConfirmPassword { get; set; }

		[StringLength(100, ErrorMessage = "Họ không được vượt quá 100 ký tự")]
		[RegularExpression(@"^[a-zA-ZÀ-ỹ\s]*$",
			ErrorMessage = "Họ chỉ được chứa chữ cái và khoảng trắng")]
		public string? FirstName { get; set; }

		[StringLength(100, ErrorMessage = "Tên không được vượt quá 100 ký tự")]
		[RegularExpression(@"^[a-zA-ZÀ-ỹ\s]*$",
			ErrorMessage = "Tên chỉ được chứa chữ cái và khoảng trắng")]
		public string? LastName { get; set; }

		[StringLength(300, ErrorMessage = "Địa chỉ không được vượt quá 300 ký tự")]
		public string? Address { get; set; }

		[Phone(ErrorMessage = "Số điện thoại không đúng định dạng")]
		[RegularExpression(@"^(84|0[3|5|7|8|9])+([0-9]{8})\b",
			ErrorMessage = "Số điện thoại không hợp lệ (Ví dụ: 0912345678 hoặc 84912345678)")]
		public string? PhoneNumber { get; set; }

		[Url(ErrorMessage = "URL ảnh đại diện không hợp lệ")]
		public string? ProfilePictureUrl { get; set; }
	}
}
