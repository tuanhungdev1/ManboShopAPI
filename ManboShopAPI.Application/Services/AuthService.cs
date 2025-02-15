using AutoMapper;
using ManboShopAPI.Application.Common.Models;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.TokenDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Google.Apis.Auth;
using System.Text;
using Newtonsoft.Json;


public class AuthService : IAuthService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;
	private readonly ILoggerService _logger;
	private readonly UserManager<User> _userManager;
	private readonly SignInManager<User> _signInManager;
	private readonly IConfiguration _configuration;
	private readonly GoogleAuthSettings _googleSettings;
	private readonly FacebookAuthSettings _facebookSettings;
	private User _user;

	public AuthService(
		IUnitOfWork unitOfWork,
		IMapper mapper,
		ILoggerService logger,
		UserManager<User> userManager,
		SignInManager<User> signInManager,
		IConfiguration configuration,
		IOptions<FacebookAuthSettings> facebookSettings,
		IOptions<GoogleAuthSettings> googleSettings)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
		_logger = logger;
		_userManager = userManager;
		_signInManager = signInManager;
		_configuration = configuration;
		_googleSettings = googleSettings.Value;
		_facebookSettings = facebookSettings.Value;
	}

	public async Task<(UserDto adminDto, TokenDto tokenDto)> LoginAdminAsync(UserForLoginDto loginDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();
			var admin =  await _userManager.FindByEmailAsync(loginDto.UserName) ?? await _userManager.FindByNameAsync(loginDto.UserName);

			if (admin == null)
			{
				_logger.LogError("Không tìm thấy thông tin người dùng.");
				throw new UserNotFoundException("Tài khoản không tồn tại trong hệ thống.");
			}

			var result = await _signInManager.PasswordSignInAsync(
				admin.UserName!,
				loginDto.Password,
				loginDto.IsRemember,
				lockoutOnFailure: false
			);

			if (!result.Succeeded)
			{
				_logger.LogError("Đăng nhập thất bại - Sai mật khẩu.");
				throw new UserBadRequestException("Tên đăng nhập hoặc mật khẩu không chính xác.");
			}

			if (!await _userManager.IsInRoleAsync(admin, "Admin"))
			{
				_logger.LogError("Đăng nhập thất bại - Không có quyền truy cập.");
				throw new UserBadRequestException("Tài khoản không có quyền truy cập.");
			}

			var adminDto = _mapper.Map<UserDto>(admin);
			adminDto.Roles = await _userManager.GetRolesAsync(admin);

			var tokenDto = await GenerateAndAssignTokensAsync(admin);

			_logger.LogInfo($"Người dùng {admin.UserName} đăng nhập thành công");

			await _unitOfWork.CommitAsync();
			return (adminDto, tokenDto);

		} catch (Exception)
		{
			_logger.LogError("Không thể đăng nhập");
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<(UserDto userDto, TokenDto tokenDto)> LoginWithFacebookAsync(string credential)
	{
		try
		{
			// Parse credential từ frontend
			var facebookCredential = JsonConvert.DeserializeObject<FacebookCredential>(credential);
			if (facebookCredential == null || string.IsNullOrEmpty(facebookCredential.AccessToken))
			{
				throw new UserBadRequestException("Thông tin đăng nhập không hợp lệ");
			}

			// Verify token with Facebook
			var client = new HttpClient();
			var verifyTokenEndpoint = $"https://graph.facebook.com/{_facebookSettings.GraphApiVersion}/debug_token";
			var response = await client.GetAsync(
				$"{verifyTokenEndpoint}?input_token={facebookCredential.AccessToken}&access_token={_facebookSettings.AppId}|{_facebookSettings.AppSecret}");

			if (!response.IsSuccessStatusCode)
			{
				throw new UserBadRequestException("Token Facebook không hợp lệ");
			}

			// Get user info from Facebook
			var userInfoEndpoint = $"https://graph.facebook.com/{_facebookSettings.GraphApiVersion}/me";
			var userInfoResponse = await client.GetAsync(
				$"{userInfoEndpoint}?fields=id,email,first_name,last_name,picture&access_token={facebookCredential.AccessToken}");

			if (!userInfoResponse.IsSuccessStatusCode)
			{
				throw new UserBadRequestException("Không thể lấy thông tin người dùng từ Facebook");
			}

			var userInfo = JsonConvert.DeserializeObject<FacebookUserInfo>(
				await userInfoResponse.Content.ReadAsStringAsync());

			if (userInfo == null || string.IsNullOrEmpty(userInfo.Email))
			{
				throw new UserBadRequestException("Không thể lấy email từ tài khoản Facebook");
			}

			// Check if user exists
			var user = await _userManager.FindByEmailAsync(userInfo.Email);

			if (user == null)
			{
				user = new User
				{
					Email = userInfo.Email,
					UserName = userInfo.Email,
					ProfilePictureUrl = userInfo.Picture?.Data?.Url,
					EmailConfirmed = true,
					FirstName = userInfo.FirstName,
					LastName = userInfo.LastName,
					PasswordHash = new Guid().ToString(),
					CreatedAt = DateTime.UtcNow,
					UpdatedAt = DateTime.UtcNow,
				};

				var result = await _userManager.CreateAsync(user);
				if (!result.Succeeded)
				{
					_logger.LogError($"Không thể tạo tài khoản cho Facebook user: {user.Email}");
					throw new UserBadRequestException("Không thể tạo tài khoản với Facebook.");
				}

				await _userManager.AddToRoleAsync(user, "Customer");
			}
			else
			{
				// Cập nhật thông tin user nếu cần
				user.ProfilePictureUrl = userInfo.Picture?.Data?.Url;
				user.FirstName = userInfo.FirstName;
				user.LastName = userInfo.LastName;
				user.UpdatedAt = DateTime.UtcNow;

				await _userManager.UpdateAsync(user);
			}

			var userDto = _mapper.Map<UserDto>(user);
			userDto.Roles = await _userManager.GetRolesAsync(user);

			var tokenDto = await GenerateAndAssignTokensAsync(user);

			_logger.LogInfo($"Đăng nhập Facebook thành công cho user: {user.Email}");

			return (userDto, tokenDto);
		}
		catch (Exception ex)
		{
			_logger.LogError($"Lỗi đăng nhập Facebook: {ex.Message}");
			throw;
		}
	}

	public async Task<(UserDto userDto, TokenDto tokenDto)> LoginWithGoogleAsync(string credential)
	{
		try
		{

			var googleUser = JsonConvert.DeserializeObject<GoogleUserInfo>(credential);
			// Kiểm tra xem user đã tồn tại chưa
			var user = await _userManager.FindByEmailAsync(googleUser.Email);

			if (user == null)
			{
				// Tạo user mới nếu chưa tồn tại
				user = new User
				{
					Email = googleUser.Email,
					UserName = googleUser.Email,
					ProfilePictureUrl = googleUser.Picture,
					EmailConfirmed = googleUser.EmailVerified,
					FirstName = googleUser.Given_Name,
					LastName = googleUser.Family_Name,
					PasswordHash = new Guid().ToString(),
					CreatedAt = DateTime.UtcNow,
					UpdatedAt = DateTime.UtcNow
				};

				var result = await _userManager.CreateAsync(user);
				if (!result.Succeeded)
				{
					_logger.LogError($"Không thể tạo tài khoản cho Google user: {user.Email}");
					throw new UserBadRequestException("Không thể tạo tài khoản với Google.");
				}

				// Gán role mặc định
				await _userManager.AddToRoleAsync(user, "Customer");
			}

			
			// Map user thành UserDto
			var userDto = _mapper.Map<UserDto>(user);
			userDto.Roles = await _userManager.GetRolesAsync(user);

			// Tạo token
			var tokenDto = await GenerateAndAssignTokensAsync(user);

			_logger.LogInfo($"Đăng nhập Google thành công cho user: {user.Email}");

			return (userDto, tokenDto);
		}
		catch (InvalidJwtException)
		{
			_logger.LogError("Token Google không hợp lệ");
			throw new UserBadRequestException("Token Google không hợp lệ");
		}
		catch (Exception ex)
		{
			_logger.LogError($"Lỗi đăng nhập Google: {ex.Message}");
			throw;
		}
	}

	public async Task<bool> CheckUsernameAvailabilityAsync(string username)
	{
		var user = await _userManager.FindByNameAsync(username);
		return user == null;
	}

	public async Task<bool> CheckEmailAvailabilityAsync(string email)
	{
		var user = await _userManager.FindByEmailAsync(email);
		return user == null;
	}

	public async Task RegisterUserAsync(UserForRegistrationDto registrationDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			bool isEmailExist = !await CheckEmailAvailabilityAsync(registrationDto.Email);
			if (isEmailExist)
			{
				_logger.LogError($"Email {registrationDto.Email} đã tồn tại trong hệ thống.");
				throw new UserBadRequestException($"Email {registrationDto.Email} đã tồn tại trong hệ thống.");
			}

			bool isUsernameExist = !await CheckUsernameAvailabilityAsync(registrationDto.UserName);
			if (isUsernameExist)
			{
				_logger.LogError($"Username {registrationDto.UserName} đã tồn tại trong hệ thống.");
				throw new UserBadRequestException($"Username {registrationDto.UserName} đã tồn tại trong hệ thống.");
			}

			var user = _mapper.Map<User>(registrationDto);
			var result = await _userManager.CreateAsync(user, registrationDto.Password);

			if (!result.Succeeded)
			{
				_logger.LogError("Đăng ký tài khoản thất bại.");
				throw new UserBadRequestException("Đăng ký tài khoản thất bại.");
			}
			var roles = new List<string> { "Customer" };
			var roleResult = await _userManager.AddToRolesAsync(user, roles);

			if (!roleResult.Succeeded)
			{
				_logger.LogError("Gán vai trò cho tài khoản thất bại.");
				throw new UserBadRequestException("Gán vai trò cho tài khoản thất bại.");
			}
			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Tạo tài khoản mới thành công cho user {user.UserName}");
		}
		catch (Exception ex)
		{
			_logger.LogError($"Đã xảy ra lỗi khi đăng ký tài khoản: {ex.Message}");
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<(UserDto userDto, TokenDto tokenDto)> LoginAsync(UserForLoginDto loginDto)
	{
		try
		{
			var user = await _userManager.FindByEmailAsync(loginDto.UserName)
					  ?? await _userManager.FindByNameAsync(loginDto.UserName);

			if (user == null)
			{
				_logger.LogError("Không tìm thấy thông tin người dùng.");
				throw new UserNotFoundException("Tài khoản không tồn tại trong hệ thống.");
			}

			var result = await _signInManager.PasswordSignInAsync(
				user.UserName!,
				loginDto.Password,
				loginDto.IsRemember,
				lockoutOnFailure: false
			);

			if (!result.Succeeded)
			{
				_logger.LogError("Đăng nhập thất bại - Sai mật khẩu.");
				throw new UserBadRequestException("Tên đăng nhập hoặc mật khẩu không chính xác.");
			}

			
			var userDto = _mapper.Map<UserDto>(user);
			userDto.Roles = await _userManager.GetRolesAsync(user);

			var tokenDto = await GenerateAndAssignTokensAsync(user);

			_logger.LogInfo($"Người dùng {user.UserName} đăng nhập thành công");

			return (userDto, tokenDto);
		}
		catch (Exception)
		{
			_logger.LogError("Không thể đăng nhập");
			throw;
		}
	}

	public async Task ChangePasswordAsync(ChangePasswordDto changePasswordDto)
	{
		try
		{
			await _unitOfWork.BeginTransactionAsync();

			var user = await _userManager.FindByNameAsync(changePasswordDto.UserName);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy user {changePasswordDto.UserName}");
				throw new UserNotFoundException($"Không tìm thấy tài khoản {changePasswordDto.UserName}");
			}

			if (changePasswordDto.CurrentPassword == changePasswordDto.NewPassword)
			{
				_logger.LogError("Mật khẩu mới phải khác mật khẩu hiện tại");
				throw new UserBadRequestException("Mật khẩu mới phải khác mật khẩu hiện tại");
			}

			var result = await _userManager.ChangePasswordAsync(
				user,
				changePasswordDto.CurrentPassword,
				changePasswordDto.NewPassword
			);

			if (!result.Succeeded)
			{
				_logger.LogError("Đổi mật khẩu thất bại");
				throw new UserBadRequestException("Đổi mật khẩu thất bại");
			}

			await _unitOfWork.SaveChangesAsync();
			await _unitOfWork.CommitAsync();

			_logger.LogInfo($"Đổi mật khẩu thành công cho user {user.UserName}");
		}
		catch (Exception)
		{
			await _unitOfWork.RollbackAsync();
			throw;
		}
	}

	public async Task<TokenDto> GenerateAndAssignTokensAsync(User user)
	{
		return await GenerateTokensForUserAsync(user, true);
	}

	private async Task<TokenDto> GenerateTokensForUserAsync(User user, bool updateRefreshToken)
	{
		var signingCredentials = GetSigningCredentials();
		var claims = await GetClaimsForUserAsync(user);
		var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
		var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
		var refreshToken = user.RefreshToken;

		if (updateRefreshToken)
		{
			refreshToken = GenerateRefreshToken();
			var jwtSettings = _configuration.GetSection("JwtSettings");
			var expires = DateTimeOffset.Now.AddDays(Convert.ToDouble(jwtSettings["RefreshTokenExpiryDays"]));

            Console.WriteLine($"Expires Refresh Token: {expires.UtcDateTime}");
            Console.WriteLine($"Current Time UTC Now: {DateTime.UtcNow}");
			Console.WriteLine($"Current Time Now: {DateTime.Now}");
			user.RefreshToken = refreshToken;
			user.RefreshTokenExpiryTime = expires.UtcDateTime;
			await _userManager.UpdateAsync(user);
			await _unitOfWork.SaveChangesAsync();
		}

		return new TokenDto
		{
			AccessToken = accessToken,
			RefreshToken = user.RefreshToken!
		};
	}

	private async Task<List<Claim>> GetClaimsForUserAsync(User user)
	{
		var claimsBuilder = new ClaimsBuilder(user)
			.AddUsername()
			.AddEmail()
			.AddUserId()
			.AddFirstname()
			.AddLastname();

		await claimsBuilder.AddRolesAsync(_userManager);
		return claimsBuilder.Build();
	}
	private async Task<TokenDto> GenerateTokensAsync(bool updateRefreshToken)
	{
		var signingCredentials = GetSigningCredentials();
		var claims = await GetClaimsAsync();
		var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
		var accessToken = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
		var refreshToken = _user.RefreshToken;

		if (updateRefreshToken)
		{
			refreshToken = GenerateRefreshToken();
			var jwtSettings = _configuration.GetSection("JwtSettings");
			var expires = DateTimeOffset.Now.AddDays(Convert.ToDouble(jwtSettings["RefreshTokenExpiryDays"]));

			_user.RefreshToken = refreshToken;
			_user.RefreshTokenExpiryTime = expires.UtcDateTime;
			await _userManager.UpdateAsync(_user);
		}

		var token = new TokenDto
		{
			AccessToken = accessToken,
			RefreshToken = refreshToken
		};

		return token;
	}

	private SigningCredentials GetSigningCredentials()
	{
		var jwtSettings = _configuration.GetSection("JwtSettings");
		var key = Encoding.UTF8.GetBytes(jwtSettings["SecurityKey"]!);
		var secret = new SymmetricSecurityKey(key);

		return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
	}

	private async Task<List<Claim>> GetClaimsAsync()
	{
		var claimsBuilder = new ClaimsBuilder(_user)
		.AddUsername()
		.AddEmail()
		.AddUserId()
		.AddFirstname()
		.AddLastname();

		await claimsBuilder.AddRolesAsync(_userManager);

		return claimsBuilder.Build();
	}
	
	private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
	{
		var jwtSettings = _configuration.GetSection("JwtSettings");
		var now = DateTimeOffset.Now;
		var expires = now.AddMinutes(Convert.ToDouble(jwtSettings["TokenExpiryMinutes"]));
		var tokenOptions = new JwtSecurityToken
		(
			issuer: jwtSettings["ValidIssuer"],
			audience: jwtSettings["ValidAudience"],
			claims: claims,
			notBefore: now.UtcDateTime,
			expires: expires.UtcDateTime,
			signingCredentials: signingCredentials
		);
		return tokenOptions;
	}

	private ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
	{
		var jwtSettings = _configuration.GetSection("JwtSettings");

		var tokenValidationParameters = new TokenValidationParameters
		{
			ValidateAudience = true,
			ValidateIssuer = true,
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(
				Encoding.UTF8.GetBytes(jwtSettings["SecurityKey"]!)),
			ValidateLifetime = false,
			ValidIssuer = jwtSettings["ValidIssuer"],
			ValidAudience = jwtSettings["ValidAudience"]
		};

		var tokenHandler = new JwtSecurityTokenHandler();
		SecurityToken securityToken;
		ClaimsPrincipal principal;

		try
		{
			principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
		}
		catch (Exception)
		{
			throw new SecurityTokenException("Invalid token");
		}

		var jwtSecurityToken = securityToken as JwtSecurityToken;
		if (jwtSecurityToken == null ||
			!jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
				StringComparison.InvariantCultureIgnoreCase))
		{
			throw new SecurityTokenException("Invalid token");
		}

		return principal;
	}



	public async Task<TokenDto> RefreshTokenAsync(TokenDto tokenDto)
	{
		var principal = GetPrincipalFromExpiredToken(tokenDto.AccessToken);
		var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);

		if (string.IsNullOrEmpty(userId))
		{
			throw new RefreshTokenBadRequestException("Không thể tìm thấy ID người dùng từ token đã hết hạn.");
		}

		var user = await _userManager.FindByIdAsync(userId);

		if (user == null)
		{
			throw new RefreshTokenBadRequestException("Người dùng không tồn tại.");
		}

		if (user.RefreshToken != tokenDto.RefreshToken)
		{
			throw new RefreshTokenBadRequestException("Refresh Token không khớp.");
		}

		if (user.RefreshTokenExpiryTime <= DateTimeOffset.UtcNow)
		{
			throw new RefreshTokenBadRequestException("Refresh Token đã hết hạn.");
		}

		_user = user;
		// Không cập nhật refresh token nếu nó chưa hết hạn
		return await GenerateTokensAsync(updateRefreshToken: false);
	}

	private string GenerateRefreshToken()
	{
		var randomNumber = new byte[32];
		using (var rng = RandomNumberGenerator.Create())
		{
			rng.GetBytes(randomNumber);
			return Convert.ToBase64String(randomNumber);
		}
	}
}