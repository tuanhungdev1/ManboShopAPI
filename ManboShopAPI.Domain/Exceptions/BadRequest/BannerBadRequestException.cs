namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class BannerBadRequestException : BadRequestException
	{
        public BannerBadRequestException(string message): base(message)
        {
            
        }
    }
}
