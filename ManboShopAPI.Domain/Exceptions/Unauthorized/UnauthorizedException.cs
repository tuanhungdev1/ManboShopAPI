namespace ManboShopAPI.Domain.Exceptions.Unauthorized
{
	public abstract class UnauthorizedException : Exception
	{
		protected UnauthorizedException(string message) : base(message) { }
	}
}
