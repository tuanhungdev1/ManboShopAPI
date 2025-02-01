namespace ManboShopAPI.Domain.Exceptions.BadRequest
{


	public class AddressBadRequestException : BadRequestException
	{
		public AddressBadRequestException()
			: base("Thông tin của thương hiệu không hợp lệ.")
		{
		}

		public AddressBadRequestException(string message)
			: base(message)
		{
		}
	}
}
