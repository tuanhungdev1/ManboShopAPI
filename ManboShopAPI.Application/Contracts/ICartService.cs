using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICartService
	{
		Task<(IEnumerable<CartDto> cartDtos, MetaData metaData)> GetAllCartAsync(CartRequestParameters cartRequestParameters);
		Task<CartDto> CreateCartAsync(CartForCreateDto cartForCreateDto);
		Task<CartDto> GetCartBySessionIdAsync(string sessionId);
		Task<CartDto> GetCartByUserIdAsync(int userId);
		Task<IEnumerable<CartDto>> GetAllCartsAsync();
		Task ClearCartAsync(int cartId);
		Task MergeCartsAsync(int sourceCartId, int destinationCartId);
		Task<decimal> GetCartTotalAsync(int cartId);
		Task<int> GetCartItemsCountAsync(int cartId);
		Task AssignCartToUserAsync(int cartId, int userId);
		Task UpdateCartSessionAsync(int cartId, string newSessionId);
		Task<OrderDto> CheckoutCart(int cartId, OrderForCreateDto orderForCreateDto);
	}
}
