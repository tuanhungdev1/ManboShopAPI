using ManboShopAPI.Application.DTOs.TokenDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.DTOs.VerificationDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IVerificationService
	{
		Task SendVerificationCodeAsync(EmailVerificationDto emailVerificationDto);
		Task<(UserDto userDto, TokenDto tokenDto)> VerifyCodeAsync(VerificationRequestDto verificationRequestDto);
	}
}
