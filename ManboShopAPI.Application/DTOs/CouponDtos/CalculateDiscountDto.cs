

using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CouponDtos
{
	public class CalculateDiscountDto
	{
		[Required(ErrorMessage = "Mã giảm giá không thể thiếu")]
		[MaxLength(200, ErrorMessage = "Mã giảm giá không được vượt quá 200 ký tự")]
		public string Code { get; set; }
		[Required(ErrorMessage = "Tổng giá trị đơn hàng không thể thiếu")]
		[Range(0, double.MaxValue, ErrorMessage = "Tổng giá trị đơn hàng không hợp lệ")]
		public decimal OrderAmount { get; set; }
	}
}
