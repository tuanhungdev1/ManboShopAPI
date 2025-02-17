

using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.CouponDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICouponService
	{
		Task<CouponDto> GetByIdAsync(int id);
		Task<CouponDto> GetByCodeAsync(string code);
		Task<(IEnumerable<CouponDto> coupons, MetaData metaData)> GetAllAsync(CouponRequestParameters parameters);
		Task<CouponDto> CreateAsync(CouponForCreateDto couponDto);
		Task<CouponDto> UpdateAsync(int id, CouponForUpdateDto couponDto);
		Task DeleteAsync(int id);
		Task<decimal> CalculateDiscountAsync(string code, decimal orderAmount);
		Task<bool> ValidateCouponAsync(string code, decimal orderAmount);
	}
}
