namespace ManboShopAPI.Application.Common.Request
{
	public class NewsDetailRequestParameters : RequestParameters
	{
        public int? NewsId { get; set; }
        public int? ProductId { get; set; }
    }
}
