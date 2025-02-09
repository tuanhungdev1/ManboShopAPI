using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Application.Contracts
{
	public interface IEmailSender
	{
		Task SendVerificationEmailAsync(string toEmail, string code);
		Task SendOrderConfirmationEmailAsync(Order order);
	}

}
