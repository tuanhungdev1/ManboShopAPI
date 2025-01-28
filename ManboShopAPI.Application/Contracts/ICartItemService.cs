using ManboShopAPI.Application.DTOs.CartItemDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICartItemService
	{
		Task<CartItemDto> AddItemToCartAsync(int cartId, CartItemForCreateDto cartItemForCreateDto);
		Task<IEnumerable<CartItemDto>> GetCartItemsByCartIdAsync(int cartId);
		Task UpdateCartItemQuantityAsync(int cartItemId, int quantity);
		Task RemoveCartItemAsync(int cartId, int productId);
		Task<decimal> GetCartItemSubtotalAsync(int cartItemId);
		Task BulkUpdateQuantitiesAsync(IEnumerable<(int CartItemId, int NewQuantity)> updates);
	}
}
