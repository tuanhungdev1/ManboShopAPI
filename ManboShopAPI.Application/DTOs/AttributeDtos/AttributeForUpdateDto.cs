using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.AttributeDtos
{
	public class AttributeForUpdateDto
	{
		[Required(ErrorMessage = "Tên thuộc tính không được để trống")]
		[MaxLength(200, ErrorMessage = "Tên thuộc tính không thể vượt quá 200 kí tự")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Giá trị thuộc tính không được để trống")]
		public string Value { get; set; }
	}
}
