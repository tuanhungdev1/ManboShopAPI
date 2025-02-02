using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.FeedbackDtos
{
	public class FeedbackReportForCreateDto
	{
		[Required(ErrorMessage = "Lý do báo cáo không được để trống.")]
		[MaxLength(500, ErrorMessage = "Lý do báo cáo không được vượt quá 500 ký tự.")]
		public string Reason { get; set; }
	}

}
