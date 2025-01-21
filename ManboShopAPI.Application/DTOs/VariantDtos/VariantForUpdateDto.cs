using ManboShopAPI.Application.DTOs.VariantValueDto;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantForUpdateDto
	{
		[Required(ErrorMessage = "Tên biến thể không được để trống")]
		public string Name { get; set; }
		public ICollection<VariantValueForUpdateDto> Values { get; set; } = new List<VariantValueForUpdateDto>();
	
	}
}
