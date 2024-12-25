using ManboShopAPI.Application.Common.Validation;

namespace ManboShopAPI.Application.DTOs.CartDtos
{
	public class CartForCreateDto
	{
		public string? SessionId { get; set; }
		public int? UserId { get; set; }
	}
}
