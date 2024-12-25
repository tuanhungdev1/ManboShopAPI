using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class RefreshTokenBadRequestException : BadRequestException
	{
		public RefreshTokenBadRequestException(string message) : base(message)
		{
		}

        public RefreshTokenBadRequestException() : base("Refresh token không hợp lệ.")
        {
            
        }
    }
}
