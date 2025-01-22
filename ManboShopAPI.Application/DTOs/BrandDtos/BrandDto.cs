namespace ManboShopAPI.Application.DTOs.BrandDtos
{
	public class BrandDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string? ImageUrl { get; set; }
		//public ICollection<Product> Products { get; set; } = new List<Product>();
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
