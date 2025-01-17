using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Application.DTOs.CategoryDtos
{
	public class CategoryDto
	{
        public int Id { get; set; }
		public string Name { get; set; }
		public string? ImageUrl { get; set; }
		public int? ParentCategoryId { get; set; }
		public ICollection<CategoryDto> SubCategories { get; set; } 
		public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
