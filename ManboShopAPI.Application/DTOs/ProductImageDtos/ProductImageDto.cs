namespace ManboShopAPI.Application.DTOs.ProductImageDtos
{
	public class ProductImageDto
	{
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
		public int ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
