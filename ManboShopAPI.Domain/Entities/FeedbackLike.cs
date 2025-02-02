namespace ManboShopAPI.Domain.Entities
{
	public class FeedbackLike : BaseEntity
	{
		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public Feedback Feedback { get; set; }
		public User User { get; set; }
	}
}
