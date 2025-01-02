using ManboShopAPI.Application.Common.Request;

namespace ManboShopAPI.Application.Common.Response
{
	public class ApiResponse<T>
	{
		public int StatusCode { get; set; }
		public bool Success { get; set; }
		public string Message { get; set; }
		public T? Data { get; set; }
        public Token? Token { get; set; }
        public List<string>? Errors { get; set; }
		public MetaData? Pagination { get; set; }
	}

}
