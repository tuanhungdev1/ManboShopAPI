using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Category : BaseEntity
	{
		[Required]
		[MaxLength(100)]
        public required string Name { get; set; }
		public int? ParentCategoryId { get; set; } 
		public Category? ParentCategory { get; set; }
		public ICollection<Category> SubCategories { get; set; } = new List<Category>();
		public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
