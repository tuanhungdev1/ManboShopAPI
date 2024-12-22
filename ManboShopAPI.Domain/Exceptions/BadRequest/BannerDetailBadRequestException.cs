using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class BannerDetailBadRequestException : BadRequestException
	{
		public BannerDetailBadRequestException(string message) : base(message)
		{
		}


	}
}
