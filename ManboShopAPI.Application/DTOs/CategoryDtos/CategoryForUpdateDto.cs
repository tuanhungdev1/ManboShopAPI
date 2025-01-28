using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.CategoryDtos
{
	public class CategoryForUpdateDto
	{
		[Required(ErrorMessage = "Tên danh mục không được để trống")]
		[MaxLength(100, ErrorMessage = "Tên danh mục không được vượt quá 100 ký tự")]
		public string Name { get; set; }
		public int? ParentCategoryId { get; set; }
	}
}
