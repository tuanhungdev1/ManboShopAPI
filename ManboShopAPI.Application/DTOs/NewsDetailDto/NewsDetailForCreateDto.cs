using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.NewsDetailDto
{
	public class NewsDetailForCreateDto
	{
		[Required(ErrorMessage = "Id bài viết không được để trống.")]
		public int NewsId { get; set; }
		[Required(ErrorMessage = "Id sản phẩm không được để trống.")]
		public int ProductId { get; set; }
	}
}
