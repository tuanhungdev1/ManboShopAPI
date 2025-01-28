using ManboShopAPI.Domain.Exceptions.BadRequest;

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
