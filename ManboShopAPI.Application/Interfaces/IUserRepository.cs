using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IUserRepository : IRepositoryBase<User>
	{
		Task<PagedList<User>> FetchAllUserAsync(UserRequestParameters userRequestParameters);
		Task<User?> GetUserByEmailAsync(string email, bool asNoTracking = false);
		Task<User?> GetUserWithOrdersAsync(int userId, bool asNoTracking = false);
		Task<bool> EmailExistsAsync(string email);
		Task<bool> UserNameExistsAsync(string userName);
		Task<bool> UserExistsAsync(int userId);
	}
}
