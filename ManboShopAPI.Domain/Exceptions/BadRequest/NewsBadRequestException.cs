namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class NewsBadRequestException : BadRequestException
	{
		public NewsBadRequestException(string message)
			: base(message)
		{
		}

		public NewsBadRequestException()
			: base("Thông tin về bài viết không hợp lệ")
		{
		}
	}
}
