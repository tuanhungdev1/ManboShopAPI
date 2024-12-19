using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{


	public sealed class BrandNotFoundException : NotFoundException
	{
		public BrandNotFoundException(int brandId)
		: base($"Không tìm thấy thương hiệu với Id: {brandId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public BrandNotFoundException(string message) : base(message)
		{

		}
	}
}
