

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class CouponBadRequestException : BadRequestException
	{
		public CouponBadRequestException(string message) : base(message)
		{
		}

		public CouponBadRequestException(int id) : base($"Coupon ID {id} không hợp lệ")
		{
		}
	}
}
