using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class CouponCondition : BaseEntity
	{
        public int CouponId { get; set; }
        public Coupon Coupon { get; set; }
		[MaxLength(100)]
        public string? Attribute { get; set; }
		[MaxLength(100)]
        public string? Operator { get; set; }
		[MaxLength(100)]
        public string? Value { get; set; }
        [Range(0, 100)]
		[Required]
		public required int DiscountAmount { get; set; }
		
	}
}
