using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Enums
{
	public enum CouponStatus
	{
		Active,    // Coupon đang hoạt động
		Expired,   // Coupon đã hết hạn
		Used,      // Coupon đã được sử dụng hết
		Inactive   // Coupon không hoạt động 
	}
}
