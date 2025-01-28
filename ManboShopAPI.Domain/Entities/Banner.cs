using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Banner : BaseEntity
	{
		[Required]
		[MaxLength(500)]
        public required string Name { get; set; }
		[Required]
        public required string ImageUrl { get; set; }
        public BannerStatus Status { get; set; } = BannerStatus.Active;
        public ICollection<BannerDetail> BannerDetails { get; set; } = new List<BannerDetail>();
    }
}
