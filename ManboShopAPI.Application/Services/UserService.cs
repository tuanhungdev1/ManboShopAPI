﻿using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ManboShopAPI.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly ICartRepository _cartRepository;
		private readonly UserManager<User> _userManager;
		private readonly IMapper _mapper;
		private readonly RoleManager<IdentityRole<int>> _roleManager;
		private readonly ILoggerService _logger;

		public UserService(
			IUserRepository userRepository,
			ICartRepository cartRepository,
			UserManager<User> userManager,
			RoleManager<IdentityRole<int>> roleManager,
			IMapper mapper,
			ILoggerService logger)
		{
			_userRepository = userRepository;
			_userManager = userManager;
			_mapper = mapper;
			_logger = logger;
			_roleManager = roleManager;
			_cartRepository = cartRepository;	
		}

		public async Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetUsersAsync(UserRequestParameters userRequestParameters)
		{
			var users = await _userRepository.FetchAllUserAsync(userRequestParameters);
			_logger.LogInfo("Lấy danh sách người dùng thành công.");
			var userDtoList = _mapper.Map<IEnumerable<UserDto>>(users);
			return (userDtoList, users.MetaData);
		}

		public async Task<UserDto> GetCurrentUserAsync(ClaimsPrincipal user)
		{
			// Extract user ID from access token
			var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				_logger.LogError("Không tìm thấy thông tin người dùng từ token.");
				throw new UnauthorizedAccessException("Không có thông tin xác thực.");
			}

			
			if (!int.TryParse(userId, out int parsedUserId))
			{
				_logger.LogError($"Không thể chuyển đổi ID người dùng: {userId}");
				throw new UserBadRequestException("Định dạng ID người dùng không hợp lệ.");
			}

			
			var userCurrent = await _userRepository
							.FindByCondition(u => u.Id == parsedUserId)
							.Include(u => u.Favorites)
							.FirstOrDefaultAsync();
			if (userCurrent == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {parsedUserId}");
				throw new UserNotFoundException(parsedUserId);
			}
			var totallCartProducts = await _cartRepository.GetTotalCartProductsForUser(parsedUserId);

			var userDto = _mapper.Map<UserDto>(userCurrent);
			var roles = await _userManager.GetRolesAsync(userCurrent);
			userDto.Roles = roles;
			userDto.TotalFavoriteProducts = userCurrent.Favorites.Count;
			userDto.TotalCartProducts = totallCartProducts;

			_logger.LogInfo("Lấy thông tin người dùng hiện tại thành công.");
			return userDto;
		}

		public async Task<UserDto> GetUserByIdAsync(int userId)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với id {userId}");
				throw new UserNotFoundException(userId);
			}

			_logger.LogInfo($"Lấy dữ liệu người dùng thành công.");
			return _mapper.Map<UserDto>(user);
		}

		public async Task<UserDto> GetUserByEmailAsync(string email)
		{
			var user = await _userRepository.GetUserByEmailAsync(email);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với email {email}");
				throw new UserNotFoundException($"Không tìm thấy người dùng với email {email}");
			}

			_logger.LogInfo($"Lấy dữ liệu người dùng thành công.");
			return _mapper.Map<UserDto>(user);
		}

		public async Task<UserDto> CreateUserAsync(UserForCreateDto userForCreateDto)
		{
			if (await _userRepository.EmailExistsAsync(userForCreateDto.Email))
			{
				_logger.LogError($"Email {userForCreateDto.Email} đã tồn tại trong hệ thống.");
				throw new UserBadRequestException($"Email {userForCreateDto.Email} đã tồn tại trong hệ thống.");
			}

			if (await _userRepository.UserNameExistsAsync(userForCreateDto.UserName))
			{
				_logger.LogError($"Tên đăng nhập {userForCreateDto.UserName} đã tồn tại trong hệ thống.");
				throw new UserBadRequestException($"Tên đăng nhập {userForCreateDto.UserName} đã tồn tại trong hệ thống.");
			}

			var rolesInDb = await _roleManager.Roles.Select(r => r.Name).ToListAsync();

			if (userForCreateDto.Roles.Any(role => !rolesInDb.Contains(role)))
			{
				_logger.LogError("Roles chứa giá trị không hợp lệ.");
				throw new UserBadRequestException($"Roles chứa giá trị không hợp lệ. Chỉ chấp nhận {string.Join(", ", rolesInDb)}.");
			}

			var user = _mapper.Map<User>(userForCreateDto);

			var passwordHasher = new PasswordHasher<User>();
			var passwordValidator = new PasswordValidator<User>();

			var passwordValidationResult = await passwordValidator.ValidateAsync(_userManager, user, userForCreateDto.Password);
			if(!passwordValidationResult.Succeeded)
			{
				var errors = string.Join(", ", passwordValidationResult.Errors.Select(e => e.Description));
				_logger.LogError($"Mật khẩu không đáp ứng yêu cầu: {errors}");
				throw new UserBadRequestException($"Mật khẩu không đáp ứng yêu cầu: {errors}");
			}
			user.PasswordHash = passwordHasher.HashPassword(user, userForCreateDto.Password);

			var result = await _userManager.CreateAsync(user, userForCreateDto.Password);

			if (!result.Succeeded)
			{
				var errors = string.Join(", ", result.Errors.Select(e => e.Description));
				_logger.LogError($"Tạo người dùng thất bại: {errors}");
				throw new UserBadRequestException($"Tạo người dùng thất bại: {errors}");
			}

			foreach(var role in userForCreateDto.Roles)
			{
				await _userManager.AddToRoleAsync(user, role);
			}
			_logger.LogInfo("Tạo người dùng mới thành công.");

			return _mapper.Map<UserDto>(user);
		}

		public async Task<UserDto> UpdateCurrentUserAsync(ClaimsPrincipal userClaim, UserForUpdateDto userForUpdateDto)
		{

			var userId = userClaim.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var user = await _userRepository.GetByIdAsync(int.Parse(userId));

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {userId}");
				throw new UserNotFoundException(userId);
			}

			// Cập nhật thông tin cá nhân
			user.FirstName = userForUpdateDto.FirstName ?? user.FirstName;
			user.LastName = userForUpdateDto.LastName ?? user.LastName;
			user.Address = userForUpdateDto.Address ?? user.Address;
			user.PhoneNumber = userForUpdateDto.PhoneNumber ?? user.PhoneNumber;


			var updateResult = await _userManager.UpdateAsync(user);
			if (!updateResult.Succeeded)
			{
				var errors = string.Join(", ", updateResult.Errors.Select(e => e.Description));
				_logger.LogError($"Cập nhật người dùng thất bại: {errors}");
				throw new UserBadRequestException($"Cập nhật người dùng thất bại: {errors}");
			}

			_logger.LogInfo("Cập nhật người dùng thành công.");

			return _mapper.Map<UserDto>(user);
		}

		public async Task<UserDto> UpdateUserAsync(int userId, UserForUpdateDto userForUpdateDto)
		{
			// Tìm người dùng theo ID
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null)
			{
				_logger.LogError($"Người dùng với ID {userId} không tồn tại.");
				throw new UserNotFoundException($"Người dùng với ID {userId} không tồn tại.");
			}

			// Cập nhật thông tin cá nhân
			user.FirstName = userForUpdateDto.FirstName ?? user.FirstName;
			user.LastName = userForUpdateDto.LastName ?? user.LastName;
			user.Address = userForUpdateDto.Address ?? user.Address;
			user.PhoneNumber = userForUpdateDto.PhoneNumber ?? user.PhoneNumber;


			var updateResult = await _userManager.UpdateAsync(user);
			if (!updateResult.Succeeded)
			{
				var errors = string.Join(", ", updateResult.Errors.Select(e => e.Description));
				_logger.LogError($"Cập nhật người dùng thất bại: {errors}");
				throw new UserBadRequestException($"Cập nhật người dùng thất bại: {errors}");
			}

			_logger.LogInfo("Cập nhật người dùng thành công.");

			return _mapper.Map<UserDto>(user);
		}

		public async Task DeleteUserAsync(int userId)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			_userRepository.Remove(user);
			await _userRepository.SaveChangesAsync();

			_logger.LogInfo($"Xóa thành công người dùng với Id {userId}");
		}

		public async Task ChangePasswordAsync(int userId, ChangePasswordDto changePasswordDto)
		{
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			var result = await _userManager.ChangePasswordAsync(
				user,
				changePasswordDto.CurrentPassword,
				changePasswordDto.NewPassword
			);

			if (!result.Succeeded)
			{
				var errors = string.Join(", ", result.Errors.Select(e => e.Description));
				_logger.LogError($"Thay đổi mật khẩu thất bại: {errors}");
				throw new UserBadRequestException($"Thay đổi mật khẩu thất bại: {errors}");
			}

			_logger.LogInfo($"Thay đổi mật khẩu thành công cho người dùng với Id {userId}");
		}

	}
}
