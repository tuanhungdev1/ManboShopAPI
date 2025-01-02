using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class ProductAttributeValue : BaseEntity
	{
        [Required]
        public string Value { get; set; }
        [Required]
        public int AttributeId { get; set; }
        public Attributes Attribute { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
