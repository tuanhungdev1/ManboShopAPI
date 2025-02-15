using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.OrderDetailDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderDto
	{
        public int Id { get; set; }
        public int UserId { get; set; }
		public UserDto User { get; set; }
		public int ShippingAddressId { get; set; }
		public OrderAddressDto ShippingAddress { get; set; }
		public string? Note { get; set; }
		public OrderStatus Status { get; set; } 
		public PaymentMethod PaymentMethod { get; set; }
		public PaymentStatus PaymentStatus { get; set; } 
		public decimal SubTotal { get; set; }  // Tổng tiền hàng
		public decimal ShippingFee { get; set; }  // Phí vận chuyển
		public decimal Total { get; set; }  // Tổng cộng
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
        public ICollection<OrderDetailDto> OrderDetails { get; set; }
		public DateTime? ConfirmedAt { get; set; }
		public DateTime? ProcessedAt { get; set; }
		public DateTime? ShippedAt { get; set; }
		public DateTime? DeliveredAt { get; set; }
		public DateTime? CancelledAt { get; set; }
	}
}
