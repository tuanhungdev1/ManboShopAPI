using ManboShopAPI.Application.DTOs.VariantValueDto;

namespace ManboShopAPI.Application.DTOs.VariantDtos
{
	public class ProductVariantValueDto
	{
		public int Id { get; set; }
		public string Sku { get; set; }
		public decimal Price { get; set; }
		public decimal? OldPrice { get; set; }
		public int Stock { get; set; }
		public ICollection<ProductVariantDetailDto> VariantCombination { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
