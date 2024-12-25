using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CartItemDtos
{
	public class UpdateCartItemQuantityDto
	{
		[Required(ErrorMessage = "Số lượng cập nhật không thể trống")]
		[Range(1, int.MaxValue, ErrorMessage = "Quantity phải lớn hơn 0.")]
		public int Quantity { get; set; }
	}
}
