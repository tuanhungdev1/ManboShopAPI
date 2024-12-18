using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class CategoryBadRequestException : BadRequestException
	{
		public CategoryBadRequestException()
			: base("Thông tin của danh mục không hợp lệ.")
		{
		}

		public CategoryBadRequestException(string message)
			: base(message)
		{
		}
	}
}
