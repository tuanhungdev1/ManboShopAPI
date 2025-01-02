using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.Common.Models;
using MimeKit;
using MailKit.Security;
using MailKit.Net.Smtp;

namespace ManboShopAPI.Application.Services
{
	public class EmailSender : IEmailSender
	{
		private readonly EmailConfiguration _emailConfig;

		public EmailSender(EmailConfiguration emailConfig)
		{
			_emailConfig = emailConfig;
		}

		public async Task<bool> SendEmailAsync(MessageForEmail message)
		{
			try
			{
				var emailMessage = CreateEmailMessage(message);
				await SendAsync(emailMessage);
				return true;
			}
			catch (Exception ex)
			{
				
				return false;
			}
		}

		private MimeMessage CreateEmailMessage(MessageForEmail message)
		{
			var emailMessage = new MimeMessage();
			emailMessage.From.Add(new MailboxAddress(_emailConfig.FromName, _emailConfig.FromAddress));
			emailMessage.To.AddRange(message.To);
			emailMessage.Subject = message.Subject;

			var builder = new BodyBuilder
			{
				HtmlBody = message.HtmlContent,
				TextBody = message.Content
			};

			emailMessage.Body = builder.ToMessageBody();
			return emailMessage;
		}

		private async Task SendAsync(MimeMessage mailMessage)
		{
			using var client = new SmtpClient();
			try
			{
				await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, SecureSocketOptions.StartTls);
				await client.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);
				await client.SendAsync(mailMessage);
			}
			finally
			{
				await client.DisconnectAsync(true);
				client.Dispose();
			}
		}
	}
}