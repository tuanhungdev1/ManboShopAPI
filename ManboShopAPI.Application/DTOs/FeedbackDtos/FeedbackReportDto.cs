using ManboShopAPI.Domain.Enums;

namespace ManboShopAPI.Application.DTOs.FeedbackDtos
{
	public class FeedbackReportDto
	{
		public int Id { get; set; }
		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public string Reason { get; set; }
		public ReportStatus Status { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
