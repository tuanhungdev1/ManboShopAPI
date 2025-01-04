using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.Common.Models;
using MimeKit;
using MailKit.Security;
using MailKit.Net.Smtp;
using ManboShopAPI.Application.Interfaces;
using Microsoft.Extensions.Options;


namespace ManboShopAPI.Application.Services
{
	public class EmailSender : IEmailSender
	{
		private readonly EmailConfiguration _emailConfig;
		private readonly ILoggerService _logger;

		public EmailSender(IOptions<EmailConfiguration> emailConfig, ILoggerService loggerService)
		{
			_emailConfig = emailConfig.Value;
			_logger = loggerService;
		}

		public async Task SendVerificationEmailAsync(string toEmail, string code)
		{
			var message = new MimeMessage();

			message.From.Add(new MailboxAddress(_emailConfig.From, _emailConfig.From));
			message.To.Add(new MailboxAddress(toEmail, toEmail));
			message.Subject = "Mã xác thực của bạn";

			var builder = new BodyBuilder();

			builder.HtmlBody = $@"
            <html>
                <body>
                    <h2>Mã xác thực của bạn</h2>
                    <p>Mã xác thực của bạn là: <strong>{code}</strong></p>
                    <p>Mã này sẽ hết hạn sau 1 phút.</p>
                </body>
            </html>";

			message.Body = builder.ToMessageBody();

			using (var client = new SmtpClient())
			{
				await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, SecureSocketOptions.StartTls);
				await client.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);
				await client.SendAsync(message);
				await client.DisconnectAsync(true);
			}

			_logger.LogInfo($"Verification code email sent to {toEmail}");
		}
	}
}