using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class BrandBadRequestException : BadRequestException
	{
		public BrandBadRequestException()
			: base("Thông tin của thương hiệu không hợp lệ.")
		{
		}

		public BrandBadRequestException(string message)
			: base(message)
		{
		}
	}
}
