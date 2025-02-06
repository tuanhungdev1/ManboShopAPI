namespace ManboShopAPI.Application.Common.Request
{
	public class ProductRequestParameters : RequestParameters
	{
        public ICollection<string>? Brands { get; set; } = new List<string>();
        public ICollection<string>? Categories { get; set; } = new List<string>();
        public string? PriceRange { get; set; }  
        public ICollection<string>? Colors { get; set; } = new List<string>();
        public ICollection<string>? Sizes { get; set; } = new List<string>();
    }

    public class PriceRange
    {
        public int Min { get; set; } = 0;
        public int Max { get; set; } = 100000000;
    }
}
