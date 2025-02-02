namespace ManboShopAPI.Application.DTOs.FeedbackDtos
{
	public class FeedbackLikeDto
	{
		public int Id { get; set; }
		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
