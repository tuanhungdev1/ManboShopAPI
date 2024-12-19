using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface IUserService
	{
		Task<Result<UserDto>> GetUserByIdAsync(int userId);
		Task<Result<UserDto>> GetUserByEmailAsync(string email);
		Task<Result<UserDto>> CreateUserAsync(CreateUserDto createUserDto);
		Task<Result<UserDto>> UpdateUserAsync(int userId, UpdateUserDto updateUserDto);
		Task<Result> DeleteUserAsync(int userId);
		Task<Result> ChangePasswordAsync(int userId, ChangePasswordDto changePasswordDto);
		Task<Result<string>> UpdateProfilePictureAsync(int userId, IFormFile file);
		Task<Result<IEnumerable<AddressDto>>> GetUserAddressesAsync(int userId);
		Task<Result<AddressDto>> AddUserAddressAsync(int userId, AddressDto addressDto);
		Task<Result> SetDefaultAddressAsync(int userId, int addressId);
		Task<Result<bool>> ValidatePasswordAsync(int userId, string password);
	}
}
