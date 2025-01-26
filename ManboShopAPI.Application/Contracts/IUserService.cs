using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface IUserService
	{
		Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetUsersAsync(UserRequestParameters userRequestParameters);
		Task<UserDto> GetUserByIdAsync(int userId);
		Task<UserDto> GetCurrentUserAsync(ClaimsPrincipal user);
		Task<UserDto> UpdateCurrentUserAsync(ClaimsPrincipal user, UserForUpdateDto userForUpdateDto);
		Task<UserDto> GetUserByEmailAsync(string email);
		Task<UserDto> CreateUserAsync(UserForCreateDto userForCreateDto);
		Task<UserDto> UpdateUserAsync(int userId, UserForUpdateDto userForUpdateDto);
		Task DeleteUserAsync(int userId);
		Task ChangePasswordAsync(int userId, ChangePasswordDto changePasswordDto);
		//Task UpdateProfilePictureAsync(int userId, IFormFile file);
		//Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId);
		//Task AddUserAddressAsync(int userId, AddressDto addressDto);
		//Task SetDefaultAddressAsync(int userId, int addressId);
		//Task<bool> ValidatePasswordAsync(int userId, string password);
	}
}
