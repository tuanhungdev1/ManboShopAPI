using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class OrderBadRequestException : BadRequestException
	{
		public OrderBadRequestException(string message) : base(message)
		{
		}

		public OrderBadRequestException()
			: base("Thông tin của đơn hàng không hợp lệ.")
		{
		}
	}
}
