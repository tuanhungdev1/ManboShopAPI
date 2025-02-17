

using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CouponDtos
{
	public class CouponForCreateDto
	{
		[Required(ErrorMessage = "Mã giảm giá là bắt buộc.")]
		[MaxLength(50, ErrorMessage = "Mã giảm giá không được vượt quá 50 ký tự.")]
		public string Code { get; set; }

		[Required(ErrorMessage = "Mô tả là bắt buộc.")]
		[MaxLength(200, ErrorMessage = "Mô tả không được vượt quá 200 ký tự.")]
		public string Description { get; set; }

		[Required(ErrorMessage = "Loại giảm giá là bắt buộc.")]
		public DiscountType DiscountType { get; set; }

		[Required(ErrorMessage = "Giá trị giảm giá là bắt buộc.")]
		[Range(0, 100000, ErrorMessage = "Giá trị giảm giá phải nằm trong khoảng từ 0 đến 100000.")]
		public decimal DiscountValue { get; set; }

		[Required(ErrorMessage = "Ngày bắt đầu là bắt buộc.")]
		public DateTime StartDate { get; set; }

		[Required(ErrorMessage = "Ngày kết thúc là bắt buộc.")]
		public DateTime EndDate { get; set; }

		public int? MaxUsage { get; set; }

		[Range(0, 100000000, ErrorMessage = "Số tiền tối thiểu phải nằm trong khoảng từ 0 đến 100000000.")]
		public decimal? MinimumAmount { get; set; }

		[Range(0, 100000000, ErrorMessage = "Số tiền giảm tối đa phải nằm trong khoảng từ 0 đến 100000000.")]
		public decimal? MaximumDiscountAmount { get; set; }
	}

}
