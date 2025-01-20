namespace ManboShopAPI.Application.DTOs.AttributeDtos
{
	public class ProductAttributeValueDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
