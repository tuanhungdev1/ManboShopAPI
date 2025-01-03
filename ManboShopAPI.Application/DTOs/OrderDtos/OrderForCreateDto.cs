﻿using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderForCreateDto
	{
		public int? UserId { get; set; }
        public string? SessionId { get; set; }

        [MaxLength(500, ErrorMessage = "Ghi chú không được vượt quá 500 ký tự.")]
		public string? Note { get; set; }

		[Required(ErrorMessage = "Trạng thái đơn hàng là bắt buộc.")]
		public OrderStatus Status { get; set; } = OrderStatus.Pending;

		[Column(TypeName = "decimal(18,2)")]
		[Range(0.01, double.MaxValue, ErrorMessage = "Tổng số tiền phải lớn hơn 0.")]
		public decimal? Total { get; set; }
	}
}
