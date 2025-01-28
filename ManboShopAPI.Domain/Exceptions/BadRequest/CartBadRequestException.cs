namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class CartBadRequestException : BadRequestException
	{
		public CartBadRequestException()
			: base("Thông tin của giỏ hàng không hợp lệ.")
		{
		}

		public CartBadRequestException(string message)
			: base(message)
		{
		}
	}
}
