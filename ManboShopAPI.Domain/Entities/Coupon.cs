using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Coupon : BaseEntity
	{
		[Required]
		[MaxLength(50)]
        public required string Code { get; set; }
		[Required]
		public DateTime ExpirationDate { get; set; }
		[Range(0, int.MaxValue)]
		[Required]
		public int MaxUsages { get; set; } = 100;
		[Range(0, int.MaxValue)]
		[Required]
		public int CurrentUsages { get; set; } = 0;
		public CouponStatus Status { get; set; } = CouponStatus.Active;
        public ICollection<CouponCondition> CouponConditions { get; set; } = new List<CouponCondition>();
		public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
