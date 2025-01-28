using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CartItemRepository : RepositoryBase<CartItem>, ICartItemRepository
	{
		public CartItemRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<CartItem?> GetCartItemAsync(int cartId, int productId)
		{
			return await _dbSet
				.Include(ci => ci.Product)
				.FirstOrDefaultAsync(ci => ci.CartId == cartId && ci.ProductId == productId);
		}

		public async Task<IEnumerable<CartItem>> GetCartItemsByCartIdAsync(int cartId, bool includeDetails = false)
		{
			IQueryable<CartItem> query = _dbSet.Where(ci => ci.CartId == cartId);

			if (includeDetails)
			{
				query = query
					.Include(ci => ci.Product)
					.Include(ci => ci.Cart);
			}

			return await query.ToListAsync();
		}

		public async Task<bool> IsProductInCartAsync(int cartId, int productId)
		{
			return await _dbSet.AnyAsync(ci =>
				ci.CartId == cartId &&
				ci.ProductId == productId);
		}

		public async Task UpdateQuantityAsync(int cartItemId, int quantity)
		{
			var cartItem = await _dbSet.FindAsync(cartItemId);
			if (cartItem != null)
			{
				cartItem.Quantity = quantity;
				_dbSet.Update(cartItem);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<int> GetTotalItemsInCartAsync(int cartId)
		{
			return await _dbSet
				.Where(ci => ci.CartId == cartId)
				.SumAsync(ci => ci.Quantity);
		}

		public async Task<decimal> GetCartItemSubtotalAsync(int cartItemId)
		{
			var cartItem = await _dbSet
				.Include(ci => ci.Product)
				.FirstOrDefaultAsync(ci => ci.Id == cartItemId);

			return cartItem != null
				? cartItem.Quantity * cartItem.Product.Price
				: 0;
		}

		public async Task RemoveCartItemAsync(int cartId, int productId)
		{
			var cartItem = await _dbSet
				.FirstOrDefaultAsync(ci =>
					ci.CartId == cartId &&
					ci.ProductId == productId);

			if (cartItem != null)
			{
				_dbSet.Remove(cartItem);
				await _context.SaveChangesAsync();
			}
		}

		public async Task RemoveExpiredCartItemsAsync(TimeSpan expirationTime)
		{
			var expirationDate = DateTime.UtcNow.Subtract(expirationTime);

			var expiredItems = await _dbSet
				.Include(ci => ci.Cart)
				.Where(ci => ci.Cart.CreatedAt < expirationDate)
				.ToListAsync();

			if (expiredItems.Any())
			{
				_dbSet.RemoveRange(expiredItems);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<bool> IsStockAvailableAsync(int productId, int requestedQuantity)
		{
			var product = await _context.Set<Product>()
				.FirstOrDefaultAsync(p => p.Id == productId);

			return product != null && product.Quantity >= requestedQuantity;
		}

		public async Task BulkUpdateQuantitiesAsync(IEnumerable<(int CartItemId, int NewQuantity)> updates)
		{
			foreach (var (cartItemId, newQuantity) in updates)
			{
				var cartItem = await _dbSet.FindAsync(cartItemId);
				if (cartItem != null)
				{
					cartItem.Quantity = newQuantity;
					_dbSet.Update(cartItem);
				}
			}

			await _context.SaveChangesAsync();
		}
	}
}
