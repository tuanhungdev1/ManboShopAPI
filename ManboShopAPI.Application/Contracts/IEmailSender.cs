using ManboShopAPI.Application.Common.Models;

namespace ManboShopAPI.Application.Contracts
{
	public interface IEmailSender
	{
		Task SendVerificationEmailAsync(string toEmail, string code);
	}

}
