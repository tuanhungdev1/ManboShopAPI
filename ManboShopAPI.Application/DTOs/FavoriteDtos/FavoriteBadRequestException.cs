using ManboShopAPI.Domain.Exceptions.BadRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.FavoriteDtos
{
	public class FavoriteBadRequestException : BadRequestException
	{
		public FavoriteBadRequestException(string message) : base(message)
		{
		}
		public FavoriteBadRequestException() : base("Thông tin không hợp lệ")
		{
		}
	}
}
