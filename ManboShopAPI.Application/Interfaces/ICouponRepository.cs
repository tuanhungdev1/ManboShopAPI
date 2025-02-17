

using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface ICouponRepository : IRepositoryBase<Coupon>
	{
		Task<bool> CodeExistsAsync(string code);
		Task<Coupon> GetByCodeAsync(string code);
		Task<PagedList<Coupon>> GetAllCouponsAsync(CouponRequestParameters parameters);
	}
}
