using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManboShopAPI.Domain.Entities
{
	public class Order : BaseEntity
	{
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? ShippingAddressId { get; set; }
		public OrderAddress ShippingAddress { get; set; }
        public string? Note { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
		[Column(TypeName = "decimal(18,2)")]
        [Required]
		public PaymentMethod PaymentMethod { get; set; }

		[Required]
		public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Pending;

		[Column(TypeName = "decimal(18,2)")]
		[Required]
		public decimal SubTotal { get; set; }  // Tổng tiền hàng

		[Column(TypeName = "decimal(18,2)")]
		[Required]
		public decimal ShippingFee { get; set; }  // Phí vận chuyển

		[Column(TypeName = "decimal(18,2)")]
		[Required]
		public decimal Total { get; set; }  // Tổng cộng

		public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

		public DateTime? ConfirmedAt { get; set; }
		public DateTime? ProcessedAt { get; set; }
		public DateTime? ShippedAt { get; set; }
		public DateTime? DeliveredAt { get; set; }
		public DateTime? CancelledAt { get; set; }
	}
}
