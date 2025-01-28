namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class CategoryBadRequestException : BadRequestException
	{
		public CategoryBadRequestException()
			: base("Thông tin của danh mục không hợp lệ.")
		{
		}

		public CategoryBadRequestException(string message)
			: base(message)
		{
		}
	}
}
