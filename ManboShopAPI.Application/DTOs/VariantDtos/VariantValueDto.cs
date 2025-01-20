namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantValueDto
	{
        public int Id { get; set; }
        public string Value { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
