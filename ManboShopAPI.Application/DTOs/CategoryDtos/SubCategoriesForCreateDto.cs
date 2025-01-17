

namespace ManboShopAPI.Application.DTOs.CategoryDtos
{
	public class SubCategoriesForCreateDto
	{
		public int ParentCategoryId { get; set; }
        public ICollection<string> ChildCategoryNames { get; set; } = new List<string>();
    }
}
