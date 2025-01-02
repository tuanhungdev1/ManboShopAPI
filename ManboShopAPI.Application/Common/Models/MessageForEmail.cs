using MimeKit;

namespace ManboShopAPI.Application.Common.Models
{
	public class MessageForEmail
	{
		public List<MailboxAddress> To { get; set; }
		public string Subject { get; set; }
		public string Content { get; set; }
		public string HtmlContent { get; set; }

		public MessageForEmail(IEnumerable<string> to, string subject, string content, string htmlContent = null)
		{
			To = new List<MailboxAddress>();
			To.AddRange(to.Select(x => new MailboxAddress(x, x)));
			Subject = subject;
			Content = content;
			HtmlContent = htmlContent ?? content;
		}
	}
}
