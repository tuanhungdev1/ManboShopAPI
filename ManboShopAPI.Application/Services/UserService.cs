﻿using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Services
{
	public class UserService : IUserService
	{
		private readonly IUserRepository _userRepository;
		private readonly UserManager<User> _userManager;
		private readonly IMapper _mapper;
		private readonly RoleManager<IdentityRole<int>> _roleManager;
		private readonly ILoggerService _logger;

		public UserService(
			IUserRepository userRepository,
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
		}

		public async Task<(IEnumerable<UserDto> userDtos, MetaData metaData)> GetUsersAsync(UserRequestParameters userRequestParameters)
		{
			var users = await _userRepository.FetchAllUserAsync(userRequestParameters);
			_logger.LogInfo("Lấy danh sách người dùng thành công.");
			var userDtoList = _mapper.Map<IEnumerable<UserDto>>(users);
			return (userDtoList, users.MetaData);
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

		public async Task<UserDto> UpdateUserAsync(int userId, UserForUpdateDto userForUpdateDto)
		{
			// Tìm người dùng theo ID
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null)
			{
				_logger.LogError($"Người dùng với ID {userId} không tồn tại.");
				throw new UserNotFoundException($"Người dùng với ID {userId} không tồn tại.");
			}

			

			// Kiểm tra email nếu nó thay đổi
			if (!string.IsNullOrEmpty(userForUpdateDto.Email) && user.Email != userForUpdateDto.Email)
			{
				if (await _userManager.FindByEmailAsync(userForUpdateDto.Email) != null)
				{
					_logger.LogError($"Email {userForUpdateDto.Email} đã tồn tại trong hệ thống.");
					throw new UserBadRequestException($"Email {userForUpdateDto.Email} đã tồn tại trong hệ thống.");
				}
				user.Email = userForUpdateDto.Email;
			}

			// Lấy danh sách roles từ cơ sở dữ liệu
			var rolesInDb = await _roleManager.Roles.Select(r => r.Name).ToListAsync();

			// Kiểm tra các giá trị roles hợp lệ nếu có
			if (userForUpdateDto.Roles != null && userForUpdateDto.Roles.Any(role => !rolesInDb.Contains(role)))
			{
				_logger.LogError("Roles chứa giá trị không hợp lệ.");
				throw new UserBadRequestException($"Roles chứa giá trị không hợp lệ. Chỉ chấp nhận {string.Join(", ", rolesInDb)}.");
			}

			// Cập nhật thông tin cá nhân
			user.FirstName = userForUpdateDto.FirstName ?? user.FirstName;
			user.LastName = userForUpdateDto.LastName ?? user.LastName;
			user.Address = userForUpdateDto.Address ?? user.Address;
			user.PhoneNumber = userForUpdateDto.PhoneNumber ?? user.PhoneNumber;
			user.ProfilePictureUrl = userForUpdateDto.ProfilePictureUrl ?? user.ProfilePictureUrl;

			// Cập nhật mật khẩu nếu có
			if (!string.IsNullOrEmpty(userForUpdateDto.CurrentPassword) &&
				!string.IsNullOrEmpty(userForUpdateDto.NewPassword) &&
				!string.IsNullOrEmpty(userForUpdateDto.ConfirmNewPassword))
			{
				var passwordValidator = new PasswordValidator<User>();
				var passwordValidationResult = await passwordValidator.ValidateAsync(_userManager, user, userForUpdateDto.NewPassword);
				if (!passwordValidationResult.Succeeded)
				{
					var errors = string.Join(", ", passwordValidationResult.Errors.Select(e => e.Description));
					_logger.LogError($"Mật khẩu mới không đáp ứng yêu cầu: {errors}");
					throw new UserBadRequestException($"Mật khẩu mới không đáp ứng yêu cầu: {errors}");
				}

				var changePasswordResult = await _userManager.ChangePasswordAsync(user, userForUpdateDto.CurrentPassword, userForUpdateDto.NewPassword);
				if (!changePasswordResult.Succeeded)
				{
					var errors = string.Join(", ", changePasswordResult.Errors.Select(e => e.Description));
					_logger.LogError($"Thay đổi mật khẩu thất bại: {errors}");
					throw new UserBadRequestException($"Thay đổi mật khẩu thất bại: {errors}");
				}
			}

			var updateResult = await _userManager.UpdateAsync(user);
			if (!updateResult.Succeeded)
			{
				var errors = string.Join(", ", updateResult.Errors.Select(e => e.Description));
				_logger.LogError($"Cập nhật người dùng thất bại: {errors}");
				throw new UserBadRequestException($"Cập nhật người dùng thất bại: {errors}");
			}

			// Cập nhật roles nếu có
			if (userForUpdateDto.Roles != null)
			{
				var currentRoles = await _userManager.GetRolesAsync(user);
				var rolesToAdd = userForUpdateDto.Roles.Except(currentRoles).ToList();
				var rolesToRemove = currentRoles.Except(userForUpdateDto.Roles).ToList();

				if (rolesToAdd.Any())
				{
					await _userManager.AddToRolesAsync(user, rolesToAdd);
				}

				if (rolesToRemove.Any())
				{
					await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
				}
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

		//public async Task UpdateProfilePictureAsync(int userId, IFormFile file)
		//{
		//	var user = await _userRepository.GetByIdAsync(userId);
		//	if (user == null)
		//	{
		//		_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
		//		throw new UserNotFoundException(userId);
		//	}

			
		//	user.UpdatedAt = DateTime.UtcNow;

		//	_userRepository.Update(user);
		//	await _userRepository.SaveChangesAsync();

		//	_logger.LogInfo($"Cập nhật ảnh đại diện thành công cho người dùng với Id {userId}");
		//}

		//public async Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId)
		//{
		//	var user = await _userRepository.GetUserWithOrdersAsync(userId);
		//	if (user == null)
		//	{
		//		_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
		//		throw new UserNotFoundException(userId);
		//	}

		//	_logger.LogInfo($"Lấy danh sách địa chỉ thành công cho người dùng với Id {userId}");
		//	return _mapper.Map<IEnumerable<AddressDto>>(user.Addresses);
		//}

		//public async Task AddUserAddressAsync(int userId, AddressDto addressDto)
		//{
		//	var user = await _userRepository.GetByIdAsync(userId);
		//	if (user == null)
		//	{
		//		_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
		//		throw new UserNotFoundException(userId);
		//	}

		//	var address = _mapper.Map<Address>(addressDto);
		//	address.UserId = userId;

		//	user.Addresses.Add(address);
		//	await _userRepository.SaveChangesAsync();

		//	_logger.LogInfo($"Thêm địa chỉ mới thành công cho người dùng với Id {userId}");
		//}

		//public async Task SetDefaultAddressAsync(int userId, int addressId)
		//{
		//	var user = await _userRepository.GetUserWithOrdersAsync(userId);
		//	if (user == null)
		//	{
		//		_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
		//		throw new UserNotFoundException(userId);
		//	}

		//	var address = user.Addresses.FirstOrDefault(a => a.Id == addressId);
		//	if (address == null)
		//	{
		//		_logger.LogError($"Không tìm thấy địa chỉ với Id {addressId}");
		//		throw new AddressNotFoundException(addressId);
		//	}

		//	foreach (var addr in user.Addresses)
		//	{
		//		addr.IsDefault = addr.Id == addressId;
		//	}

		//	await _userRepository.SaveChangesAsync();
		//	_logger.LogInfo($"Đặt địa chỉ mặc định thành công cho người dùng với Id {userId}");
		//}

		//public async Task<bool> ValidatePasswordAsync(int userId, string password)
		//{
		//	var user = await _userManager.FindByIdAsync(userId.ToString());
		//	if (user == null)
		//	{
		//		_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
		//		throw new UserNotFoundException(userId);
		//	}

		//	var result = await _userManager.CheckPasswordAsync(user, password);
		//	_logger.LogInfo($"Kiểm tra mật khẩu thành công cho người dùng với Id {userId}");
		//	return result;
		//}
	}
}