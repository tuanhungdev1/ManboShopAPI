using ManboShopAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class FeedbackReport : BaseEntity
	{
		public int? FeedbackId { get; set; }
		public int UserId { get; set; }
		[Required]
		[MaxLength(500)]
		public string Reason { get; set; }
		public ReportStatus Status { get; set; } = ReportStatus.Pending;
		public Feedback? Feedback { get; set; }
		public User User { get; set; }
	}
}
