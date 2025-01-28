using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.BannerDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IBannerService
	{
		Task<(IEnumerable<BannerDto> bannerDtos, MetaData metaData)> GetAllBannersAsync(BannerRequestParameters bannerRequestParameters);
		Task<BannerDto> GetBannerByIdAsync(int bannerId);
		Task CreateBannerAsync(BannerForCreateDto bannerForCreateDto);
		Task UpdateBannerAsync(int bannerId, BannerForUpdateDto bannerForUpdateDto);
		Task DeleteBannerAsync(int bannerId);
		Task<IEnumerable<BannerDto>> GetActiveBannersAsync();
	}
}
