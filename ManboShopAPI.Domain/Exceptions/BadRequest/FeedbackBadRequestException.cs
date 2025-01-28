namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class FeedbackBadRequestException : BadRequestException
	{
		public FeedbackBadRequestException(string message) : base(message)
		{
		}
	} 
}
