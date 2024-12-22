using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IBannerRepository : IRepositoryBase<Banner>
	{
		Task<PagedList<Banner>> FetchAllBannerAsync(BannerRequestParameters bannerRequestParameters);
		Task<IEnumerable<Banner>> GetActiveBannersAsync(bool asNoTracking = false);
		Task<Banner?> GetBannerWithDetailsAsync(int id, bool asNoTracking = false);
		Task<bool> IsBannerExistAsync(string name);
	}
}
