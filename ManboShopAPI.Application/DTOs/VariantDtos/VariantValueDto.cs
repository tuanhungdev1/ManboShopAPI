namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantValueDto
	{
        public int Id { get; set; }
		public int VariantId { get; set; }
		public string Value { get; set; }
        public ICollection<VariantValueImageDto> VariantValueImages { get; set; } = new List<VariantValueImageDto>();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
