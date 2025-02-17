using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.Common.Request
{
	public class OrderRequestParameters : RequestParameters
	{
        public OrderStatus? OrderStatus { get; set; }
        public DateTime? FormDate { get; set; }
		public DateTime? ToDate { get; set; }

	
	}
}
