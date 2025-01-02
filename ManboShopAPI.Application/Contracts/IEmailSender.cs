using ManboShopAPI.Application.Common.Models;

namespace ManboShopAPI.Application.Contracts
{
	public interface IEmailSender
	{
		Task<bool> SendEmailAsync(MessageForEmail message);
	}

}
