using ManboShopAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class Order : BaseEntity
	{
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string? SessionId { get; set; }
        [MaxLength(500)]
        public string? Note { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
		[Column(TypeName = "decimal(18,2)")]
        [Required]
		public decimal Total { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
    }
}
