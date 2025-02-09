using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using ManboShopAPI.Application.DTOs.AddressDtos;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderForCreateDto
	{
		[Required(ErrorMessage = "Người dùng không được để trống.")]
		public int UserId { get; set; }
        public int? AddressId { get; set; }
        public AddressForCreateDto? AddressForCreate { get; set; }
		[Required(ErrorMessage = "Phương thức thanh toán không được để trống.")]
        public PaymentMethod PaymentMethod { get; set; }

        [MaxLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
		public string? Note { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.Pending;
	}
}
