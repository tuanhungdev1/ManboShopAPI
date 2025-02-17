

using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.CouponDtos
{
	public class CouponDto
	{
		public int Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public DiscountType DiscountType { get; set; }
		public decimal DiscountValue { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public int? MaxUsage { get; set; }
		public int UsageCount { get; set; }
		public decimal? MinimumAmount { get; set; }
		public decimal? MaximumDiscountAmount { get; set; }
		public bool IsActive { get; set; }
	}
}
