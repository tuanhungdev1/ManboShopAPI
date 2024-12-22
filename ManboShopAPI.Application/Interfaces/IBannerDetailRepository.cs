using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IBannerDetailRepository : IRepositoryBase<BannerDetail>
	{
		Task<IEnumerable<BannerDetail>> GetBannerDetailsByBannerIdAsync(int bannerId, bool asNoTracking = false);
		Task<IEnumerable<BannerDetail>> GetBannerDetailsByProductIdAsync(int productId, bool asNoTracking = false);
		Task<BannerDetail?> GetBannerDetailAsync(int bannerId, int productId, bool asNoTracking = false);
		Task<bool> IsBannerDetailExistAsync(int bannerId, int productId);
	}
}
