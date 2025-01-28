using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.NewsDetailDto
{
	public class NewsDetailForUpdateDto
	{
		[Required(ErrorMessage = "Id bài viết không được để trống.")]
		public int NewsId { get; set; }
		[Required(ErrorMessage = "Id sản phẩm không được để trống.")]
		public int ProductId { get; set; }
    }
}
