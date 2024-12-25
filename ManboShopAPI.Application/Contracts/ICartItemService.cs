using ManboShopAPI.Application.DTOs.CartItemDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface ICartItemService
	{
		Task<CartItemDto> AddItemToCartAsync(CartItemForCreateDto cartItemForCreateDto);
		Task<IEnumerable<CartItemDto>> GetCartItemsByCartIdAsync(int cartId);
		Task UpdateCartItemQuantityAsync(int cartItemId, int quantity);
		Task RemoveCartItemAsync(int cartId, int productId);
		Task<decimal> GetCartItemSubtotalAsync(int cartItemId);
		Task BulkUpdateQuantitiesAsync(IEnumerable<(int CartItemId, int NewQuantity)> updates);
	}
}
