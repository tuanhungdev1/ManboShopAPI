using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.ProductDtos
{
	public class ProductForUpdateQuantityDto
	{
		[Required(ErrorMessage = "Số lượng sản phẩm không được để trống")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng sản phẩm phải là số nguyên dương hoặc bằng 0")]
		public required int Quantity { get; set; }
	}
}
