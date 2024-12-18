using ManboShopAPI.Application.Common.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Response
{
	public class ApiResponse<T>
	{
		public int StatusCode { get; set; }
		public bool Success { get; set; }
		public string Message { get; set; }
		public T? Data { get; set; }
		public List<string>? Errors { get; set; }
		public MetaData? Pagination { get; set; }
	}

}
