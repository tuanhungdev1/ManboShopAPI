namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantValueImageDto
	{
        public int Id { get; set; }
		public int VariantValueId { get; set; }
		public string ImageUrl { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
