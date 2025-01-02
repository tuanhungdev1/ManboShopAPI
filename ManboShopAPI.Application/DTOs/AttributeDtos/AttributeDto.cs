namespace ManboShopAPI.Application.DTOs.AttributeDtos
{
	public class AttributeDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
