using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.NewsDtos
{
	public class NewsForUpdateDto
	{
		[Required(ErrorMessage = "Tiêu đề không được để trống.")]
		[MaxLength(300, ErrorMessage = "Tiêu đề không được dài quá 300 ký tự.")]
		public required string Title { get; set; }

		[Required(ErrorMessage = "URL hình ảnh không được để trống.")]
		public required string ImageUrl { get; set; }

		[Required(ErrorMessage = "Nội dung không được để trống.")]
		public required string Content { get; set; }

		[Required(ErrorMessage = "Danh sách ID sản phẩm không được để trống.")]
		public required List<int> ProductIds { get; set; }
	}
}
