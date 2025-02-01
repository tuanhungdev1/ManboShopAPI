using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IAddressRepository : IRepositoryBase<Address>
	{
		Task<IEnumerable<Address>> GetAddressesByUserIdAsync(int userId, bool asNoTracking = false);
		Task<Address?> GetDefaultAddressForUserAsync(int userId, bool asNoTracking = false);
		Task<bool> HasDefaultAddressAsync(int userId);
		Task<bool> IsAddressOwnerAsync(int addressId, int userId);
		Task SetDefaultAddressAsync(int addressId, int userId);
		Task<Address?> GetAddressWithUserAsync(int addressId, bool asNoTracking = false);
		Task<int> GetUserAddressCountAsync(int userId);
	}
}
