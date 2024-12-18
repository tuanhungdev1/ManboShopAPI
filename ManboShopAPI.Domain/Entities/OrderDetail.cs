using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class OrderDetail : BaseEntity
	{
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? CouponId { get; set; }
        public Coupon? Coupon { get; set; }
    }
}
