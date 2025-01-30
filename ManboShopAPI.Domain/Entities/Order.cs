using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManboShopAPI.Domain.Entities
{
	public class Order : BaseEntity
	{
        public int? UserId { get; set; }
        public User? User { get; set; }
        public string? Note { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
		[Column(TypeName = "decimal(18,2)")]
        [Required]
		public decimal Total { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
