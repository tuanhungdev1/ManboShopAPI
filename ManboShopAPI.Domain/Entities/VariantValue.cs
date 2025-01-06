namespace ManboShopAPI.Domain.Entities
{
	public class VariantValue : BaseEntity
	{
        public int VariantId { get; set; }
        public Variant Variant { get; set; }
        public string Value { get; set; }
    }
}
