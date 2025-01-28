namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class CartNotFoundException : NotFoundException
	{
		public CartNotFoundException(string sessionId)
			: base($"Không tìm thấy giỏ hàng với SessionId {sessionId}")
		{
		}

		public CartNotFoundException(int userId)
			: base($"Không tìm thấy giỏ hàng với UserID {userId}")
		{
		}

		public CartNotFoundException(int userId, int cartId)
			: base($"Không tìm thấy giỏ hàng với UserID {userId} và CartId {cartId}")
		{
		}

		public CartNotFoundException(string message, bool innerException = false)
			: base(message)
		{
		}
	}
}
