using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.BannerDtos
{
	public class BannerDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public BannerStatus Status { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		//public ICollection<BannerDetailDto> BannerDetails { get; set; }
	}
}
