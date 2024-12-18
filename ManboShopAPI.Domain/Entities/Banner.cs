using ManboShopAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
