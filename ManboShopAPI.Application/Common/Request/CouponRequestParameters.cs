

namespace ManboShopAPI.Application.Common.Request
{
	public class CouponRequestParameters : RequestParameters
	{
        public bool? IsActive { get; set; }
        public DateTime? FormDate { get; set; }
		public DateTime? ToDate { get; set; }

    }
}
