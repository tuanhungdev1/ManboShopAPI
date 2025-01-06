using ManboShopAPI.Application.DTOs.AttributeDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.DTOs.VariantValueDto;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.ProductDtos
{
	public class ProductForCreateDto
	{
		[Required(ErrorMessage = "Tên sản phẩm không được để trống")]
		[MaxLength(100, ErrorMessage = "Tên sản phẩm không được vượt quá 100 ký tự")]
		public required string Name { get; set; }

		[Required(ErrorMessage = "Mô tả sản phẩm không được để trống")]
		[MaxLength(1000, ErrorMessage = "Mô tả sản phẩm không được vượt quá 1000 ký tự")]
		public required string Description { get; set; }

		public string? Specification { get; set; }

		[Required(ErrorMessage = "Giá sản phẩm không được để trống")]
		[Range(0, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn hoặc bằng 0")]
		public decimal Price { get; set; }

		[Required(ErrorMessage = "Giá cũ không được để trống")]
		[Range(0, double.MaxValue, ErrorMessage = "Giá cũ phải lớn hơn hoặc bằng 0")]
		public decimal OldPrice { get; set; }

		[Required(ErrorMessage = "Số lượng sản phẩm không được để trống")]
		[Range(0, int.MaxValue, ErrorMessage = "Số lượng sản phẩm phải lớn hơn hoặc bằng 0")]
		public int Quantity { get; set; }

		public int? CategoryId { get; set; }

		public int? BrandId { get; set; }
		[Required(ErrorMessage = "Hình ảnh sản phẩm không được để trống, bạn nên upload ít nhất 1 và nhiều nhất là 5 hình ảnh")]
		public List<IFormFile> Images { get; set; } = new List<IFormFile>();
        public ICollection<AttributeForCreateDto> AttributeForCreateDtos { get; set; } = new List<AttributeForCreateDto>();
        public ICollection<VariantForCreateDto> Variants { get; set; } = new List<VariantForCreateDto>();
        public ICollection<VariantValueForCreateDto> VariantValues { get; set; } = new List<VariantValueForCreateDto>();
    }
}
