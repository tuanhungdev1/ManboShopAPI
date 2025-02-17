

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public class CouponNotFoundException : NotFoundException
	{
		public CouponNotFoundException(string message) : base(message)
		{
		}

        public CouponNotFoundException(int id) : base($"Không tìm thấy Coupon với ID {id}")
        {
            
        }
    }
}
