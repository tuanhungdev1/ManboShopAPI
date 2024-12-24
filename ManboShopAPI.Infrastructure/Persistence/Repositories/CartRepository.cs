using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CartRepository : RepositoryBase<Cart>, ICartRepository
	{
		public CartRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<Cart?> GetCartBySessionIdAsync(int sessionId, bool includeItems = false)
		{
			IQueryable<Cart> query = _dbSet;

			if (includeItems)
			{
				query = query
					.Include(c => c.CartItems)
					.ThenInclude(ci => ci.Product);
			}

			return await query
				.FirstOrDefaultAsync(c => c.SessionId == sessionId);
		}

		public async Task<Cart?> GetCartByUserIdAsync(int userId, bool includeItems = false)
		{
			IQueryable<Cart> query = _dbSet;

			if (includeItems)
			{
				query = query
					.Include(c => c.CartItems)
					.ThenInclude(ci => ci.Product);
			}

			return await query
				.FirstOrDefaultAsync(c => c.UserId == userId);
		}

		public async Task<bool> IsCartExistsAsync(int sessionId)
		{
			return await _dbSet.AnyAsync(c => c.SessionId == sessionId);
		}

		public async Task<IEnumerable<Cart>> GetCartsWithItemsAsync()
		{
			return await _dbSet
				.Include(c => c.CartItems)
				.ThenInclude(ci => ci.Product)
				.Include(c => c.User)
				.ToListAsync();
		}

		public async Task<int> GetCartItemsCountAsync(int cartId)
		{
			return await _dbSet
				.Where(c => c.Id == cartId)
				.SelectMany(c => c.CartItems)
				.SumAsync(ci => ci.Quantity);
		}

		public async Task ClearCartAsync(int cartId)
		{
			var cart = await _dbSet
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.Id == cartId);

			if (cart != null)
			{
				_context.RemoveRange(cart.CartItems);
				await _context.SaveChangesAsync();
			}
		}

		public async Task MergeCartsAsync(int sourceCartId, int destinationCartId)
		{
			var sourceCart = await _dbSet
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.Id == sourceCartId);

			var destinationCart = await _dbSet
				.Include(c => c.CartItems)
				.FirstOrDefaultAsync(c => c.Id == destinationCartId);

			if (sourceCart == null || destinationCart == null)
				return;

			foreach (var sourceItem in sourceCart.CartItems)
			{
				var existingItem = destinationCart.CartItems
					.FirstOrDefault(i => i.ProductId == sourceItem.ProductId);

				if (existingItem != null)
				{
					existingItem.Quantity += sourceItem.Quantity;
				}
				else
				{
					destinationCart.CartItems.Add(new CartItem
					{
						ProductId = sourceItem.ProductId,
						Quantity = sourceItem.Quantity,
						CartId = destinationCartId
					});
				}
			}

			_dbSet.Remove(sourceCart);
			await _context.SaveChangesAsync();
		}

		public async Task<decimal> GetCartTotalAsync(int cartId)
		{
			return await _dbSet
				.Where(c => c.Id == cartId)
				.SelectMany(c => c.CartItems)
				.SumAsync(ci => ci.Quantity * ci.Product.Price);
		}

		public async Task UpdateCartSessionAsync(int cartId, int newSessionId)
		{
			var cart = await _dbSet.FindAsync(cartId);
			if (cart != null)
			{
				cart.SessionId = newSessionId;
				await _context.SaveChangesAsync();
			}
		}

		public async Task AssignCartToUserAsync(int cartId, int userId)
		{
			var cart = await _dbSet.FindAsync(cartId);
			if (cart != null)
			{
				cart.UserId = userId;
				await _context.SaveChangesAsync();
			}
		}
	}
}
