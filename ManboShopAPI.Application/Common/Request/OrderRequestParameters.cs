using ManboShopAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Request
{
	public class OrderRequestParameters : RequestParameters
	{
        public OrderStatus? OrderStatus { get; set; }
        public DateTime? FormDate { get; set; }
		public DateTime? ToDate { get; set; }
    }
}
