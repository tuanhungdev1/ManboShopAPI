namespace ManboShopAPI.Application.Common.Request
{
	public class FeedbackRequestParameters : RequestParameters
	{
        public int? RateNumber { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
