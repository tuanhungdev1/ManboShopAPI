using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class UserBadRequestException : BadRequestException
	{
		public UserBadRequestException(string message)
			: base(message) { }

		public UserBadRequestException()
			: base("Thông tin của thương hiệu không hợp lệ.")
		{
		}
	}
}
