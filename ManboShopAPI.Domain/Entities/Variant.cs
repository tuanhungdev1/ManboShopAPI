using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Variant : BaseEntity
	{
		[Required]
		[MaxLength(100)]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<VariantValue> VariantValues { get; set; } = new List<VariantValue>();
    }
}
