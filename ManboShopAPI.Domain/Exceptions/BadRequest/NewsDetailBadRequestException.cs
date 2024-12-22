using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class NewsDetailBadRequestException : BadRequestException
	{
		public NewsDetailBadRequestException(string message) : base(message)
		{
		}

		
	}
	
}
