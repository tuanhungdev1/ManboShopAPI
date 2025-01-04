using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class VerificationBadRequestException : BadRequestException
	{
		public VerificationBadRequestException(string message) : base(message) { }

        public VerificationBadRequestException() : base("Mã xác nhận không hợp lệ.") { }
    }
}
