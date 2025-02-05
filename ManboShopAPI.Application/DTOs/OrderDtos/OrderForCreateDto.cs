﻿using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderForCreateDto
	{
		public int UserId { get; set; }

        [MaxLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
		public string? Note { get; set; }
		public OrderStatus Status { get; set; } = OrderStatus.Pending;

		[Column(TypeName = "decimal(18,2)")]
		[Range(0.01, double.MaxValue, ErrorMessage = "Tổng số tiền phải lớn hơn 0.")]
		public decimal? Total { get; set; }
	}
}
