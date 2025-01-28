namespace ManboShopAPI.Application.Common.Request
{
	public class NewsRequestParameters : RequestParameters
	{
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
    }
}
