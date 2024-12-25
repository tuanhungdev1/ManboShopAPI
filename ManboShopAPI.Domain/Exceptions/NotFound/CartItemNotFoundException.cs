using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class CartItemNotFoundException : NotFoundException
	{
		public CartItemNotFoundException(int cartItemId) : base($"Không tìm thấy sản phẩm trong giỏ hàng với Id {cartItemId}")
		{
		}

        public CartItemNotFoundException(string message): base(message)
        {
            
        }
    }
}
