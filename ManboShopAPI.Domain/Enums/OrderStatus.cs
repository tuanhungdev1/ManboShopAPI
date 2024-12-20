using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Enums
{
	public enum OrderStatus
	{
		Pending = 1,     
		Processing = 2,   
		Shipped = 3,     
		Delivered = 4,    
		Cancelled = 5    
	}
}
