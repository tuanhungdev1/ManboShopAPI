using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class BannerDetailNotFoundException : NotFoundException
	{
		public BannerDetailNotFoundException(int bannerId, int productId) : base($"Không tìm thấy chi tiết banner với BannerId {bannerId} và ProductId {productId}")
		{
		}

        public BannerDetailNotFoundException(string message) : base(message)
        {
            
        }

        public BannerDetailNotFoundException(int bannerDetailId) : base($"Không tìm thấy chi tiết banner với Id {bannerDetailId}")
        {
            
        }
    }
}
