using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManboShopAPI.Domain.Entities
{
	public class Coupon : BaseEntity
	{
		[Required]
		[MaxLength(50)]
        public required string Code { get; set; }
		[Required]
		[MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public DiscountType DiscountType { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
        public decimal DiscountValue { get; set; }
		[Required]
        public DateTime StartDate { get; set; }
		[Required]
		public DateTime EndDate { get; set; }
        public int? MaxUsage { get; set; }
		public int UsageCount { get; set; } = 0;
		[Column(TypeName = "decimal(18,2)")]
        public decimal? MinimumAmount { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal? MaximumDiscountAmount { get; set; }
		public bool IsActive { get; set; } = true;
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
