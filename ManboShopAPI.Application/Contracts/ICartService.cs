using ManboShopAPI.Application.DTOs.CartDtos;
using ManboShopAPI.Application.DTOs.CartItemDtos;
using ManboShopAPI.Application.DTOs.OrderDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICartService
	{
		// Các phương thức quản lý Cart cơ bản
		Task<CartDto> GetCartBySessionIdAsync(string sessionId);
		Task<CartDto> GetCartByUserIdAsync(int userId);
		Task<CartDto> GetOrCreateCartBySessionAsync(string sessionId);
		Task<CartDto> GetOrCreateCartByUserAsync(int userId);
		Task<CartDto> CreateCartAsync(CartForCreateDto cartDto);
		Task DeleteCartAsync(int cartId);

		// Các phương thức quản lý CartItem
		Task<CartItemDto> AddItemToCartAsync(int cartId, CartItemForCreateDto cartItemDto);
		Task<CartItemDto> UpdateCartItemAsync(int cartId, int cartItemId, CartItemForUpdateDto cartItemDto);
		Task RemoveCartItemAsync(int cartId, int cartItemId);
		Task<IEnumerable<CartItemDto>> GetCartItemsAsync(int cartId);
		Task ClearCartAsync(int cartId);

		// Các phương thức tính toán cơ bản
		Task<decimal> GetCartTotalAsync(int cartId);
		Task<int> GetCartItemsCountAsync(int cartId);

		// Các phương thức xử lý session và user
		Task AssignCartToUserAsync(int cartId, int userId);
		Task MergeSessionCartToUserCart(string sessionId, int userId);

		// Phương thức checkout
		Task<OrderDto> CheckoutCartAsync(int cartId, OrderForCreateDto orderForCreateDto);
	}
}
