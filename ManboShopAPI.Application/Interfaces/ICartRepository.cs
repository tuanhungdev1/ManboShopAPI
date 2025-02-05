using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface ICartRepository : IRepositoryBase<Cart>
	{
		Task<PagedList<Cart>> FetchAllCartAsync(CartRequestParameters cartRequestParameters);
		Task<int> GetTotalCartProductsForUser(int userId);
		Task<Cart?> GetCartBySessionIdAsync(string sessionId, bool includeItems = false);
		Task<Cart?> GetCartByUserIdAsync(int userId, bool includeItems = false);
		Task<bool> IsCartExistsAsync(string sessionId);
		Task<IEnumerable<Cart>> GetCartsWithItemsAsync();
		Task<int> GetCartItemsCountAsync(int cartId);
		Task ClearCartAsync(int cartId);
		Task MergeCartsAsync(int sourceCartId, int destinationCartId);
		Task<decimal> GetCartTotalAsync(int cartId);
		Task UpdateCartSessionAsync(int cartId, string newSessionId);
		Task AssignCartToUserAsync(int cartId, int userId);
	}
}
