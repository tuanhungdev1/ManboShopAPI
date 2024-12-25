using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface ICartRepository : IRepositoryBase<Cart>
	{
		Task<PagedList<Cart>> FetchAllCartAsync(CartRequestParameters cartRequestParameters);
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
