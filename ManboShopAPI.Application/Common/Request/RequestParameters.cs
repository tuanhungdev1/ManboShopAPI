namespace ManboShopAPI.Application.Common.Request
{
	public abstract class RequestParameters
	{
		const int maxPageSize = 100;
		public int PageNumber { get; set; } = 1;
		private int _pageSize = 10;
		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set
			{
				_pageSize = (value > maxPageSize) ? maxPageSize : value;
			}
		}
		public string? SearchTerm { get; set; }
		public string? OrderBy { get; set; }
        public string? OrderKey { get; set; }
    }
}
