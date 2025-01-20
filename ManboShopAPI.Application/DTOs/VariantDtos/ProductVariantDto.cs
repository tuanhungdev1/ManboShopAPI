namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class ProductVariantDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<VariantValueDto> Values { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
