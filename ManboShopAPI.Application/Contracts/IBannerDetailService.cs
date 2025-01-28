using ManboShopAPI.Application.DTOs.BannerDetailDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IBannerDetailService
	{
		Task<IEnumerable<BannerDetailDto>> GetBannerDetailsByBannerIdAsync(int bannerId);
		Task<IEnumerable<BannerDetailDto>> GetBannerDetailsByProductIdAsync(int productId);
		Task<BannerDetailDto> GetBannerDetailAsync(int bannerId, int productId);
		Task<BannerDetailDto> GetBannerDetailByIdAsync(int bannerDetailId);
		Task<IEnumerable<BannerDetailDto>> GetAllBannerDetailAsync();
		Task CreateBannerDetailAsync(BannerDetailForCreateDto bannerDetailForCreateDto);
		Task UpdateBannerDetailAsync(int bannerDetailId, BannerDetailForUpdateDto bannerDetailForUpdateDto);
		Task DeleteBannerDetailAsync(int bannerDetailId);
	}
}
