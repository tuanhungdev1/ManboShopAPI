

using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class UpdateOrderStatusDto
	{
        public string? Note { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
