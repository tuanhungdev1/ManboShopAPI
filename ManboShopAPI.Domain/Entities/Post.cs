

using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Post : BaseEntity
	{
		[Required]
		public string Title { get; set; }
		[Required]
		public string Content { get; set; } // JSON format
		public string? Description { get; set; }
		public string Slug { get; set; }
		public string? ThumbnailUrl { get; set; }
		public bool IsPublished { get; set; } = false;
		public DateTime? PublishedAt { get; set; }
		public int ViewCount { get; set; }
		public int LikeCount { get; set; }

		public int AuthorId { get; set; }
		public User Author { get; set; }

		public ICollection<PostCategory> Categories { get; set; } = new List<PostCategory>();
		public ICollection<PostTag> Tags { get; set; } = new List<PostTag>();
		public ICollection<PostComment> Comments { get; set; } = new List<PostComment>();
		public ICollection<PostLike> Likes { get; set; } = new List<PostLike>();
	}
}
