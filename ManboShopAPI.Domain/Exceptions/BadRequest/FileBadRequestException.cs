namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public class FileBadRequestException : BadRequestException
	{
		public FileBadRequestException(string message) : base(message)
		{
		}
	}
}
