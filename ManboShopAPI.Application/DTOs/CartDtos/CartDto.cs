using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CartDtos
{
	public class CartDto
	{
        public int Id { get; set; }
        public int SessionId { get; set; }
		public int? UserId { get; set; }
		public User? User { get; set; }
		public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
