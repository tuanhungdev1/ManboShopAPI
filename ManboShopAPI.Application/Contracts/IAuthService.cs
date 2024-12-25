using ManboShopAPI.Application.DTOs.TokenDtos;
using ManboShopAPI.Application.DTOs.UserDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IAuthService
	{
		Task<bool> CheckUsernameAvailabilityAsync(string username);
		Task<bool> CheckEmailAvailabilityAsync(string email);
		Task RegisterUserAsync(UserForRegistrationDto registrationDto);
		Task<(UserDto userDto, TokenDto tokenDto)> LoginAsync(UserForLoginDto loginDto);
		Task ChangePasswordAsync(ChangePasswordDto changePasswordDto);
		Task<TokenDto> RefreshTokenAsync(TokenDto tokenDto);
	}
}
