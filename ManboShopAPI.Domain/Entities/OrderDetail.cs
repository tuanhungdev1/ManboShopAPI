using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManboShopAPI.Domain.Entities
{
	public class OrderDetail : BaseEntity
	{
		[Required]
		public int OrderId { get; set; }
		public Order Order { get; set; }
		[Required]
		public int ProductVariantValueId { get; set; }
		public ProductVariantValue ProductVariantValue { get; set; }
		[Required]
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

	}
}
