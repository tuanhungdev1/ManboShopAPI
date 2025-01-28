namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class VerificationBadRequestException : BadRequestException
	{
		public VerificationBadRequestException(string message) : base(message) { }

        public VerificationBadRequestException() : base("Mã xác nhận không hợp lệ.") { }
    }
}
