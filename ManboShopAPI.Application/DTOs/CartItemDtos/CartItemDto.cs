using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class CartItemDto
	{
        public int Id { get; set; }
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public ProductDto Product { get; set; }
		public int Quantity { get; set; }
		public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
