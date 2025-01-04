using AutoMapper;
using ManboShopAPI.Application.Common.Helpers;
using ManboShopAPI.Application.Common.Models;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.TokenDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.DTOs.VerificationDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security;

namespace ManboShopAPI.Application.Services
{
	public class VerificationService : IVerificationService
	{
		private readonly IEmailSender _emailSender;
		private readonly UserManager<User> _userManager;
		private readonly ILoggerService _logger;
		private readonly IUnitOfWork _unitOfWork;
		private readonly JwtSettings jwtSettings;
		private readonly IAuthService _jwtService;
		private readonly IMapper _mapper;

		public VerificationService(
			IEmailSender emailSender,
			IAuthService jwtService,
			UserManager<User> userManager,
			IUnitOfWork unitOfWork,
			IOptions<JwtSettings> jwtSettings,
			IMapper mapper,
			ILoggerService logger)
		{
			_mapper = mapper;
			_emailSender = emailSender;
			_jwtService = jwtService;
			_userManager = userManager;
			_logger = logger;
			this.jwtSettings = jwtSettings.Value;
			_unitOfWork = unitOfWork;
		}

		public async Task SendVerificationCodeAsync(EmailVerificationDto emailVerificationDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();
				var user = await _userManager.FindByEmailAsync(emailVerificationDto.Email);
				if (user == null)
				{
					_logger.LogError($"Không tìm thấy user với email {emailVerificationDto.Email}");
					throw new UserNotFoundException($"Không tìm thấy user với email {emailVerificationDto.Email}");
				}

				var code = CodeGenerator.GenerateCode();
				var expiryTime = DateTime.UtcNow.AddMinutes(1);

				user.VerificationCode = code;
				user.VerificationCodeExpiryTime = expiryTime;

				var result = await _userManager.UpdateAsync(user);
				await _unitOfWork.SaveChangesAsync();
				if (!result.Succeeded)
				{
					_logger.LogError("Lỗi khi cập nhật mã xác thực cho user");
					throw new VerificationException("Lỗi khi cập nhật mã xác thực cho user");
				}

				await _emailSender.SendVerificationEmailAsync(emailVerificationDto.Email, code);
				_logger.LogInfo($"Đã gửi mã xác thực đến email {emailVerificationDto.Email}");
				await _unitOfWork.CommitAsync();
			} catch (Exception ex)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Lỗi khi gửi mã xác thực: {ex.Message}");
				throw;
			}
		}

		public async Task<(UserDto userDto, TokenDto tokenDto)> VerifyCodeAsync(VerificationRequestDto verificationRequestDto)
		{
			var user = await _userManager.FindByEmailAsync(verificationRequestDto.Email);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy user với email {verificationRequestDto.Email}");
				throw new UserNotFoundException($"Không tìm thấy user với email {verificationRequestDto.Email}");
			}

			if (string.IsNullOrEmpty(user.VerificationCode))
			{
				_logger.LogError("Không tìm thấy mã xác thực");
				throw new VerificationException("Không tìm thấy mã xác thực");
			}

			if (DateTime.UtcNow > user.VerificationCodeExpiryTime)
			{
				user.VerificationCode = null;
				user.VerificationCodeExpiryTime = null;
				await _userManager.UpdateAsync(user);

				_logger.LogError("Mã xác thực đã hết hạn");
				throw new VerificationBadRequestException("Mã xác thực đã hết hạn");
			}

			if (verificationRequestDto.Code != user.VerificationCode)
			{
				_logger.LogError("Mã xác thực không đúng");
				throw new VerificationException("Mã xác thực không đúng");
			}

			// Xác thực email thành công
			user.EmailConfirmed = true;
			user.VerificationCode = null;
			user.VerificationCodeExpiryTime = null;

			var result = await _userManager.UpdateAsync(user);
			if (!result.Succeeded)
			{
				_logger.LogError("Lỗi khi cập nhật trạng thái xác thực email");
				throw new VerificationException("Lỗi khi cập nhật trạng thái xác thực email");
			}

			var tokenDto = await _jwtService.GenerateAndAssignTokensAsync(user);
			var userDto = _mapper.Map<UserDto>(user);
			_logger.LogInfo($"Xác thực email thành công cho user {verificationRequestDto.Email}");

			return (userDto, tokenDto);
		}
	}
}
