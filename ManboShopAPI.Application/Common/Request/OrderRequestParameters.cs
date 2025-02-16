using ManboShopAPI.Domain.Enums;
using Microsoft.IdentityModel.Tokens;

namespace ManboShopAPI.Application.Common.Request
{
	public class OrderRequestParameters : RequestParameters
	{
        public OrderStatus? OrderStatus { get; set; }
        public DateTime? FormDate { get; set; }
		public DateTime? ToDate { get; set; }

	
	}
}
