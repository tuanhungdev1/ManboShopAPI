using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class BannerDetail : BaseEntity
	{
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
    }
}
