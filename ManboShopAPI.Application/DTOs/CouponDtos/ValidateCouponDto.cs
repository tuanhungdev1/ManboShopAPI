
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CouponDtos
{
	public class ValidateCouponDto
	{
		[Required(ErrorMessage = "Mã giảm giá không thể thiếu")]
		[MaxLength(50, ErrorMessage = "Mã giảm giá không được vượt quá 50 ký tự")]
		public string Code { get; set; }
		[Required(ErrorMessage = "Tổng giá trị đơn hàng không thể thiếu")]
		[Range(0, double.MaxValue, ErrorMessage = "Tổng giá trị đơn hàng không hợp lệ")]
		public decimal OrderAmount { get; set; }
	}
}
