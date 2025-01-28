namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class ProductBadRequestException : BadRequestException
	{
		public ProductBadRequestException()
			: base("Thông tin sản phẩm không hợp lệ.")
		{
		}

		public ProductBadRequestException(string message)
			: base(message)
		{
		}
	}
}
