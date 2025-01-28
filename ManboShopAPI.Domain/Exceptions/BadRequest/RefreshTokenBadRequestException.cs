namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class RefreshTokenBadRequestException : BadRequestException
	{
		public RefreshTokenBadRequestException(string message) : base(message)
		{
		}

        public RefreshTokenBadRequestException() : base("Refresh token không hợp lệ.")
        {
            
        }
    }
}
