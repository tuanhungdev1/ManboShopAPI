using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class NewsDetailNotFoundException : NotFoundException
	{
		public NewsDetailNotFoundException(int newsDetailId)
		: base($"Không tìm thấy chi tiết bài viết với Id: {newsDetailId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public NewsDetailNotFoundException(string message) : base(message)
		{

		}
	}
}
