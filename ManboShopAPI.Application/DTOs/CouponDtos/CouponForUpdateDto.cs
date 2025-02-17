

using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CouponDtos
{
	public class CouponForUpdateDto
	{
		[MaxLength(200, ErrorMessage = "Mô tả không được vượt quá 200 ký tự.")]
		public string Description { get; set; }

		public DateTime? StartDate { get; set; }
		public DateTime? EndDate { get; set; }

		[Range(1, int.MaxValue, ErrorMessage = "Số lần sử dụng tối đa phải lớn hơn hoặc bằng 1.")]
		public int? MaxUsage { get; set; }

		[Range(0, 100000000, ErrorMessage = "Số tiền tối thiểu phải nằm trong khoảng từ 0 đến 100000000.")]
		public decimal? MinimumAmount { get; set; }

		[Range(0, 100000000, ErrorMessage = "Số tiền giảm tối đa phải nằm trong khoảng từ 0 đến 100000000.")]
		public decimal? MaximumDiscountAmount { get; set; }

		public bool? IsActive { get; set; }
	}
}
