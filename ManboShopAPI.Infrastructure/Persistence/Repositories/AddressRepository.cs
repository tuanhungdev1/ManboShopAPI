using ManboShopAPI.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class AddressRepository : RepositoryBase<Address>, IAddressRepository
	{
		private readonly ApplicationDbContext _context;

		public AddressRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Address>> GetAddressesByUserIdAsync(int userId, bool asNoTracking = false)
		{
			var query = _context.Addresses
				.Where(a => a.UserId == userId)
				.OrderByDescending(a => a.IsDefault)
				.ThenByDescending(a => a.CreatedAt);

			return asNoTracking
				? await query.AsNoTracking().ToListAsync()
				: await query.ToListAsync();
		}

		public async Task<Address?> GetDefaultAddressForUserAsync(int userId, bool asNoTracking = false)
		{
			var query = _context.Addresses
				.Where(a => a.UserId == userId && a.IsDefault);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<bool> HasDefaultAddressAsync(int userId)
		{
			return await _context.Addresses
				.AnyAsync(a => a.UserId == userId && a.IsDefault);
		}

		public async Task<bool> IsAddressOwnerAsync(int addressId, int userId)
		{
			return await _context.Addresses
				.AnyAsync(a => a.Id == addressId && a.UserId == userId);
		}

		public async Task SetDefaultAddressAsync(int addressId, int userId)
		{
			using var transaction = await _context.Database.BeginTransactionAsync();
			try
			{
				// Remove default from all user's addresses
				var currentDefaultAddresses = await _context.Addresses
					.Where(a => a.UserId == userId && a.IsDefault)
					.ToListAsync();

				foreach (var address in currentDefaultAddresses)
				{
					address.IsDefault = false;
					_context.Addresses.Update(address);
				}

				// Set new default address
				var newDefaultAddress = await _context.Addresses
					.FirstOrDefaultAsync(a => a.Id == addressId && a.UserId == userId);

				if (newDefaultAddress != null)
				{
					newDefaultAddress.IsDefault = true;
					_context.Addresses.Update(newDefaultAddress);
				}

				await _context.SaveChangesAsync();
				await transaction.CommitAsync();
			}
			catch
			{
				await transaction.RollbackAsync();
				throw;
			}
		}

		public async Task<Address?> GetAddressWithUserAsync(int addressId, bool asNoTracking = false)
		{
			var query = _context.Addresses
				.Include(a => a.User)
				.Where(a => a.Id == addressId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<int> GetUserAddressCountAsync(int userId)
		{
			return await _context.Addresses
				.Where(a => a.UserId == userId)
				.CountAsync();
		}

		public override async Task AddAsync(Address address)
		{
			// If this is the first address for the user, make it default
			if (!await HasDefaultAddressAsync(address.UserId))
			{
				address.IsDefault = true;
			}
			await base.AddAsync(address);
		}

		public override void Update(Address address)
		{
			// Ensure we don't accidentally remove the default status if this is the only address
			if (!address.IsDefault)
			{
				var addressCount = _context.Addresses
					.Where(a => a.UserId == address.UserId)
					.Count();

				if (addressCount == 1)
				{
					address.IsDefault = true;
				}
			}
			base.Update(address);
		}

		public override void Remove(Address address)
		{
			// If removing default address, set another address as default if exists
			if (address.IsDefault)
			{
				var nextDefaultAddress = _context.Addresses
					.Where(a => a.UserId == address.UserId && a.Id != address.Id)
					.OrderByDescending(a => a.CreatedAt)
					.FirstOrDefault();

				if (nextDefaultAddress != null)
				{
					nextDefaultAddress.IsDefault = true;
					_context.Addresses.Update(nextDefaultAddress);
				}
			}
			base.Remove(address);
		}
	}
}
