using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class OrderNotFoundException : NotFoundException
	{
		public OrderNotFoundException(int orderId)
		: base($"Không tìm thấy đơn hàng với Id: {orderId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public OrderNotFoundException(string message) : base(message)
		{

		}
	}
}
