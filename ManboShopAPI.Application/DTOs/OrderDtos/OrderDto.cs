using ManboShopAPI.Application.DTOs.OrderDetailDtos;
using ManboShopAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.OrderDtos
{
	public class OrderDto
	{
		public int Id { get; set; }
		public int? UserId { get; set; }
        public string? SessionId { get; set; }
        public string? Note { get; set; }
		public OrderStatus Status { get; set; }
		public decimal Total { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
        public ICollection<OrderDetailDto> OrderDetails { get; set; }
    }
}
