using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.TokenDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

[ApiController]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class AuthController : ControllerBase
{
	private readonly IAuthService _authService;

	public AuthController(IAuthService authService) =>
		_authService = authService;

	[HttpPost("check-username/{username}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<bool>> CheckUsername( string username)
	{
		var isAvailable = await _authService.CheckUsernameAvailabilityAsync(username);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Data = isAvailable,
			Message = "Kiểm tra username thành công."
		});
	}

	[HttpPost("check-email/{email}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<bool>> CheckEmail( string email)
	{
		var isAvailable = await _authService.CheckEmailAvailabilityAsync(email);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Data = isAvailable,
			Message = "Kiểm tra email thành công."
		});
	}

	[HttpPost("register")]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<IActionResult> Register([FromBody] UserForRegistrationDto registrationDto)
	{
		await _authService.RegisterUserAsync(registrationDto);
		return StatusCode(201, new ApiResponse<object>
		{
			StatusCode = 201,
			Success = true,
			Message = "Đăng ký tài khoản thành công."
		});
	}

	[HttpPost("login")]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<(UserDto, TokenDto)>> Login([FromBody] UserForLoginDto loginDto)
	{
		var (userDto, tokenDto) = await _authService.LoginAsync(loginDto);
		var token = new Token
		{
			AccessToken = tokenDto.AccessToken,
			RefreshToken = tokenDto.RefreshToken
		};
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Đăng nhập thành công.",
			Data = new { User = userDto},
			Token = token
		});
	}

	[HttpPut("change-password")]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
	{
		await _authService.ChangePasswordAsync(changePasswordDto);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Đổi mật khẩu thành công."
		});
	}

	[HttpPost("refresh-token")]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<ActionResult<TokenDto>> RefreshToken([FromBody] TokenDto tokenDto)
	{
		var newToken = await _authService.RefreshTokenAsync(tokenDto);
		var token = new Token
		{
			AccessToken = newToken.AccessToken,
			RefreshToken = newToken.RefreshToken
		};
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Refresh token thành công.",
			Token = token
		});
	}
}