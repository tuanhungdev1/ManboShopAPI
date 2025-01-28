namespace ManboShopAPI.Domain.Exceptions.BadRequest
{
	public sealed class CartItemBadRequestException : BadRequestException
	{
        public CartItemBadRequestException(string message) : base(message)
        {
            
        }
    }
}
