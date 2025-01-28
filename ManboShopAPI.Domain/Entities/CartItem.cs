using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class CartItem : BaseEntity
	{
        [Required]
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        [Required]
		public int ProductVariantValueId { get; set; }
		public ProductVariantValue ProductVariantValue { get; set; }
		[Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
