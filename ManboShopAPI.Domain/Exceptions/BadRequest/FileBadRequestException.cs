using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class FileBadRequestException : BadRequestException
	{
		public FileBadRequestException(string message) : base(message)
		{
		}
	}
}
