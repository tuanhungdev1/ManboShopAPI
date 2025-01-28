namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public class FavoriteNotFoundException : NotFoundException
	{
		public FavoriteNotFoundException(int userId, int productId)
		: base($"Không tìm thấy sản phẩm với Id: {productId} trong danh mục yêu thích của người dùng Id: {userId}")
		{
		}

		public FavoriteNotFoundException(string message) : base(message)
		{

		}
	}
}
