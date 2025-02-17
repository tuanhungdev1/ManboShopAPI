using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class PostCategory : BaseEntity
	{
		[Required]
		public string Name { get; set; }
		public string Slug { get; set; }
		public string? Description { get; set; }
		public ICollection<Post> Posts { get; set; } = new List<Post>();
	}
}
