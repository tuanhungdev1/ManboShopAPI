using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserForUpdateDto
	{
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
	}
}
