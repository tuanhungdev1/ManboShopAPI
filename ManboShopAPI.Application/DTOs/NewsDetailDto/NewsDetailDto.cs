using ManboShopAPI.Application.DTOs.NewsDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.DTOs.NewsDetailDto
{
	public class NewsDetailDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int NewsId { get; set; }
		public ProductDto Product { get; set; }
		public NewsDto News { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
