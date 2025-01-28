namespace ManboShopAPI.Domain.Exceptions.NotFound
{


	public sealed class BrandNotFoundException : NotFoundException
	{
		public BrandNotFoundException(int bannerId)
		: base($"Không tìm thấy banner với Id: {bannerId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public BrandNotFoundException(string message) : base(message)
		{

		}
	}
}
