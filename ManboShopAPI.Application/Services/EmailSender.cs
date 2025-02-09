using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.Common.Models;
using MimeKit;
using MailKit.Security;
using MailKit.Net.Smtp;
using ManboShopAPI.Application.Interfaces;
using Microsoft.Extensions.Options;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;


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

		public async Task SendOrderConfirmationEmailAsync(Order order)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress(_emailConfig.From, _emailConfig.From));
			message.To.Add(new MailboxAddress(order.ShippingAddress.Name, order.User?.Email ?? ""));
			message.Subject = $"Xác nhận đơn hàng #{order.Id}";

			var builder = new BodyBuilder();
			builder.HtmlBody = GenerateOrderConfirmationEmailHtml(order);
			message.Body = builder.ToMessageBody();

			try
			{
				using (var client = new SmtpClient())
				{
					await client.ConnectAsync(_emailConfig.SmtpServer, _emailConfig.Port, SecureSocketOptions.StartTls);
					await client.AuthenticateAsync(_emailConfig.UserName, _emailConfig.Password);
					await client.SendAsync(message);
					await client.DisconnectAsync(true);
				}
				_logger.LogInfo($"Order confirmation email sent for Order #{order.Id}");
			}
			catch (Exception ex)
			{
				_logger.LogError($"Failed to send order confirmation email for Order #{order.Id}: {ex.Message}");
				throw;
			}
		}

		private string GenerateOrderConfirmationEmailHtml(Order order)
		{
			var items = order.OrderDetails.Select(od =>
				$@"<tr>
                <td>{od.ProductVariantValue.Product.Name}</td>
                <td>{od.Quantity}</td>
                <td>{od.Price:N0}đ</td>
                <td>{(od.Price * od.Quantity):N0}đ</td>
            </tr>");

			return $@"
        <html>
            <head>
                <style>
                    table {{ border-collapse: collapse; width: 100%; }}
                    th, td {{ border: 1px solid #ddd; padding: 8px; text-align: left; }}
                    th {{ background-color: #f2f2f2; }}
                </style>
            </head>
            <body>
                <h2>Xác nhận đơn hàng #{order.Id}</h2>
                <p>Xin chào {order.ShippingAddress.Name},</p>
                <p>Cảm ơn bạn đã đặt hàng tại cửa hàng chúng tôi. Dưới đây là thông tin chi tiết đơn hàng của bạn:</p>

                <h3>Thông tin giao hàng:</h3>
                <p>
                    Người nhận: {order.ShippingAddress.Name}<br/>
                    Số điện thoại: {order.ShippingAddress.PhoneNumber}<br/>
                    Địa chỉ: {order.ShippingAddress.AddressLine}<br/>
                    {order.ShippingAddress.PostalCode}, {order.ShippingAddress.Country}, {order.ShippingAddress.City}
                </p>

                <h3>Chi tiết đơn hàng:</h3>
                <table>
                    <tr>
                        <th>Sản phẩm</th>
                        <th>Số lượng</th>
                        <th>Đơn giá</th>
                        <th>Thành tiền</th>
                    </tr>
                    {string.Join("", items)}
                </table>

                <div style='margin-top: 20px;'>
                    <p>
                        Tạm tính: {order.SubTotal:N0}đ<br/>
                        Phí vận chuyển: {order.ShippingFee:N0}đ<br/>
                        <strong>Tổng cộng: {order.Total:N0}đ</strong>
                    </p>
                </div>

                <h3>Phương thức thanh toán:</h3>
                <p>{(order.PaymentMethod == PaymentMethod.COD ? "Thanh toán khi nhận hàng (COD)" : order.PaymentMethod.ToString())}</p>

                <p>
                    Chúng tôi sẽ thông báo cho bạn khi đơn hàng được xử lý và giao hàng.<br/>
                    Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ với chúng tôi.
                </p>

                <p>Trân trọng,<br/>Đội ngũ cửa hàng</p>
            </body>
        </html>";
		}
	}
}