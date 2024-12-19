using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class ProductNotFoundException : NotFoundException
	{
		public ProductNotFoundException(int productId)
			: base($"Không tìm thấy sản phẩm với Id: {productId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public ProductNotFoundException(string message) : base(message)
		{
		}
	}
}
