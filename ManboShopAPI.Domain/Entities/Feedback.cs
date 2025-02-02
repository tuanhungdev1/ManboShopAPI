using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Feedback : BaseEntity
	{
		[Required]
		[MaxLength(1000)]
		public string Title { get; set; }
		[Required]
		[MaxLength(1000)]
        public string Content { get; set; }
		[Range(0, 5)]
		[Required]
        public int Star { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
		public ICollection<FeedbackLike> FeedbackLikes { get; set; } = new List<FeedbackLike>();
		public ICollection<FeedbackReport> FeedbackReports { get; set; } = new List<FeedbackReport>();
	}
}
