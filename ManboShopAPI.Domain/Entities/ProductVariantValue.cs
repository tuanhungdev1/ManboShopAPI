using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManboShopAPI.Domain.Entities
{
	public class ProductVariantValue : BaseEntity
	{
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public Decimal Price { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public Decimal OldPrice { get; set; }
		[Required]
		[Range(0, int.MaxValue)]
		public int Stock { get; set; }
        [Required]
		[MaxLength(100)]
        public string Sku { get; set; }
    }
}
