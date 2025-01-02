using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Attributes : BaseEntity
	{
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
        public ICollection<ProductAttributeValue> ProductAttributeValues { get; set; } = new List<ProductAttributeValue>();
    }
}
