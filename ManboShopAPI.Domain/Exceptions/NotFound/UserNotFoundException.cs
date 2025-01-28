namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class UserNotFoundException : NotFoundException
	{
		public UserNotFoundException(int userId)
			: base($"Không tìm thấy người dùng với Id {userId} trong hệ thống") { }

		public UserNotFoundException(string message)
			: base(message) { }
	}
}
