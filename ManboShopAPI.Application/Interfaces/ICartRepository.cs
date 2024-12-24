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
		Task<Cart?> GetCartBySessionIdAsync(int sessionId, bool includeItems = false);
		Task<Cart?> GetCartByUserIdAsync(int userId, bool includeItems = false);
		Task<bool> IsCartExistsAsync(int sessionId);
		Task<IEnumerable<Cart>> GetCartsWithItemsAsync();
		Task<int> GetCartItemsCountAsync(int cartId);
		Task ClearCartAsync(int cartId);
		Task MergeCartsAsync(int sourceCartId, int destinationCartId);
		Task<decimal> GetCartTotalAsync(int cartId);
		Task UpdateCartSessionAsync(int cartId, int newSessionId);
		Task AssignCartToUserAsync(int cartId, int userId);
	}
}
