﻿using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;


namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderForCreateDto
	{
		[Required(ErrorMessage = "Giỏ hàng không được để trống.")]
        public int CartId { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống.")]
        public int AddressId { get; set; }
		[Required(ErrorMessage = "Phương thức thanh toán không được để trống.")]
        public PaymentMethod PaymentMethod { get; set; }

        [MaxLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
		public string? Note { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.Pending;
	}
}
