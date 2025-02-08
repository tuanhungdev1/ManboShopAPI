using ManboShopAPI.Domain.Entities;


namespace ManboShopAPI.Application.Services
{
	public class VariantValueImage : BaseEntity
	{
		public int? VariantValueId { get; set; }
		public VariantValue? VariantValue { get; set; }
		public string ImageUrl { get; set; }
	}
}
