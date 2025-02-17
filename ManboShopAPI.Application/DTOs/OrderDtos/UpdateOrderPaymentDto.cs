

using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class UpdateOrderPaymentDto
	{
        public string? Note { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
