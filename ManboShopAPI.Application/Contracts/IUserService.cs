using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.UserDtos;
using System.Security.Claims;

namespace ManboShopAPI.Application.Contracts
{
	public interface IUserService
	{
		//Lock User
		Task LockUserAsync(int userId, DateTime? endDate);
		Task UnLockUserAsync(int userId);
		Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetUsersAsync(UserRequestParameters userRequestParameters);
		Task<UserDto> GetUserByIdAsync(int userId);
		Task<UserDto> GetCurrentUserAsync(ClaimsPrincipal user);
		Task<UserDto> UpdateCurrentUserAsync(ClaimsPrincipal user, UserForUpdateDto userForUpdateDto);
		Task<UserDto> GetUserByEmailAsync(string email);
		Task<UserDto> CreateUserAsync(UserForCreateDto userForCreateDto);
		Task<UserDto> UpdateUserAsync(int userId, UserForUpdateDto userForUpdateDto);
		Task DeleteUserAsync(int userId);
		Task ChangePasswordAsync(int userId, ChangePasswordDto changePasswordDto);
		Task UpdateProfilePictureAsync(int userId, UserUpdateAvatarDto updateAvatarDto);
		//Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId);
		//Task AddUserAddressAsync(int userId, AddressDto addressDto);
		//Task SetDefaultAddressAsync(int userId, int addressId);
		//Task<bool> ValidatePasswordAsync(int userId, string password);
	}
}
