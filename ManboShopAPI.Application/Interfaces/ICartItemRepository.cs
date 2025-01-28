using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface ICartItemRepository : IRepositoryBase<CartItem>
	{
		Task<CartItem?> GetCartItemAsync(int cartId, int productId);
		Task<IEnumerable<CartItem>> GetCartItemsByCartIdAsync(int cartId, bool includeDetails = false);
		Task<bool> IsProductInCartAsync(int cartId, int productId);
		Task UpdateQuantityAsync(int cartItemId, int quantity);
		Task<int> GetTotalItemsInCartAsync(int cartId);
		Task<decimal> GetCartItemSubtotalAsync(int cartItemId);
		Task RemoveCartItemAsync(int cartId, int productId);
		Task RemoveExpiredCartItemsAsync(TimeSpan expirationTime);
		Task<bool> IsStockAvailableAsync(int productId, int requestedQuantity);
		Task BulkUpdateQuantitiesAsync(IEnumerable<(int CartItemId, int NewQuantity)> updates);
	}
}
