using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CartRepository : RepositoryBase<Cart>, ICartRepository
	{
		public CartRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<PagedList<Cart>> FetchAllCartAsync(CartRequestParameters cartRequestParameters)
		{
			var query = _dbSet
						.Include(c => c.CartItems)
						.ThenInclude(ci => ci.Product)
						.Include(c => c.User)
						.AsNoTracking().AsQueryable();

			if (!string.IsNullOrWhiteSpace(cartRequestParameters.SearchTerm))
			{
				query = query.Where(c => c.User.LastName.Contains(cartRequestParameters.SearchTerm)
										|| c.User.FirstName.Contains(cartRequestParameters.SearchTerm)
										|| c.User.Email.Contains(cartRequestParameters.SearchTerm)
										|| c.User.UserName.Contains(cartRequestParameters.SearchTerm)
				);
			}

			if (!string.IsNullOrWhiteSpace(cartRequestParameters.OrderBy))
			{
				var orderKey = cartRequestParameters.OrderKey?.Trim().ToLower() ?? "";
				var orderBy = cartRequestParameters.OrderBy.Trim().ToLower();
				query = orderKey switch
				{
					"created" => orderBy == "desc" ? query.OrderByDescending(b => b.CreatedAt) : query.OrderBy(b => b.CreatedAt),
					_ => query.OrderBy(b => b.Id),
				};

			}

			var totalCount = await query.CountAsync();

			var items = await query
				.Skip((cartRequestParameters.PageNumber - 1) * cartRequestParameters.PageSize)
				.Take(cartRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<Cart>(items, totalCount, cartRequestParameters.PageNumber, cartRequestParameters.PageSize);
		}

		public async Task<Cart?> GetCartBySessionIdAsync(string sessionId, bool includeItems = false)
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

		public async Task<bool> IsCartExistsAsync(string sessionId)
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

		public async Task UpdateCartSessionAsync(int cartId, string newSessionId)
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
