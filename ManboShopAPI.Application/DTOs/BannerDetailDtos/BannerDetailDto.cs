using ManboShopAPI.Application.DTOs.BannerDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;

namespace ManboShopAPI.Application.DTOs.BannerDetailDtos
{
	public class BannerDetailDto
	{
        public int Id { get; set; }
        public int ProductId { get; set; }
		public ProductDto Product { get; set; }
		public int BannerId { get; set; }
		public BannerDto Banner { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
    }
}
