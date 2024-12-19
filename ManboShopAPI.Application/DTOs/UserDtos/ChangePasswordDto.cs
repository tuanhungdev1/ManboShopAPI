using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class ChangePasswordDto
	{
		[Required(ErrorMessage = "Mật khẩu mới không được để trống")]
		[StringLength(100, MinimumLength = 6,
			ErrorMessage = "Mật khẩu mới phải có độ dài từ 6 đến 100 ký tự")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
			ErrorMessage = "Mật khẩu mới phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt")]
		public string CurrentPassword { get; set; }

		[Required(ErrorMessage = "Mật khẩu mới không được để trống")]
		[StringLength(100, MinimumLength = 6,
			ErrorMessage = "Mật khẩu mới phải có độ dài từ 6 đến 100 ký tự")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$",
			ErrorMessage = "Mật khẩu mới phải chứa ít nhất 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt")]
		public string NewPassword { get; set; }

		[Compare("NewPassword", ErrorMessage = "Mật khẩu xác nhận không khớp với mật khẩu mới")]
		public string ConfirmNewPassword { get; set; }
	}
}
