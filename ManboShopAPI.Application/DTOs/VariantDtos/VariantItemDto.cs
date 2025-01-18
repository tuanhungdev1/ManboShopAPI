using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class VariantItemDto
	{
		[Required(ErrorMessage = "Tên Gía Trị biến thể là bắt buộc.")]
		[MaxLength(100, ErrorMessage = "Tên Gía Trị biến thể không được vượt quá 100 ký tự.")]
		public required string  Value { get; set; }
        public IFormFile? FileImage { get; set; }
    }
}
