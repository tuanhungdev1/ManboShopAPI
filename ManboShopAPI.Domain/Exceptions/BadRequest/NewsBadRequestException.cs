using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class NewsBadRequestException : BadRequestException
	{
		public NewsBadRequestException(string message)
			: base(message)
		{
		}

		public NewsBadRequestException()
			: base("Thông tin về bài viết không hợp lệ")
		{
		}
	}
}
