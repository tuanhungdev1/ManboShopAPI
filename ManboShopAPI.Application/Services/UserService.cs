using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
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
		private readonly IFileService _fileService;
		private readonly ILoggerService _logger;

		public UserService(
			IUserRepository userRepository,
			UserManager<User> userManager,
			IMapper mapper,
			IFileService fileService,
			ILoggerService logger)
		{
			_userRepository = userRepository;
			_userManager = userManager;
			_mapper = mapper;
			_fileService = fileService;
			_logger = logger;
		}

		public async Task<UserDto> GetUserByIdAsync(int userId)
		{
			var user = await _userRepository.GetUserWithOrdersAsync(userId);
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

			var user = _mapper.Map<User>(userForCreateDto);
			var result = await _userManager.CreateAsync(user, userForCreateDto.Password);

			if (!result.Succeeded)
			{
				var errors = string.Join(", ", result.Errors.Select(e => e.Description));
				_logger.LogError($"Tạo người dùng thất bại: {errors}");
				throw new UserBadRequestException($"Tạo người dùng thất bại: {errors}");
			}

			await _userManager.AddToRoleAsync(user, "User");
			_logger.LogInfo("Tạo người dùng mới thành công.");

			return _mapper.Map<UserDto>(user);
		}

		public async Task<UserDto> UpdateUserAsync(int userId, UserForUpdateDto userForUpdateDto)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			_mapper.Map(userForUpdateDto, user);
			user.UpdatedAt = DateTime.UtcNow;

			_userRepository.Update(user);
			await _userRepository.SaveChangesAsync();

			_logger.LogInfo($"Cập nhật thành công người dùng với Id {userId}");
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

			if (!string.IsNullOrEmpty(user.ProfilePictureUrl))
			{
				await _fileService.DeleteFileAsync(user.ProfilePictureUrl);
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

		public async Task UpdateProfilePictureAsync(int userId, IFormFile file)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			if (!string.IsNullOrEmpty(user.ProfilePictureUrl))
			{
				await _fileService.DeleteFileAsync(user.ProfilePictureUrl);
			}

			var uploadResult = await _fileService.UploadFileAsync(file, "profile-pictures");
			user.ProfilePictureUrl = uploadResult;
			user.UpdatedAt = DateTime.UtcNow;

			_userRepository.Update(user);
			await _userRepository.SaveChangesAsync();

			_logger.LogInfo($"Cập nhật ảnh đại diện thành công cho người dùng với Id {userId}");
		}

		public async Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId)
		{
			var user = await _userRepository.GetUserWithOrdersAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			_logger.LogInfo($"Lấy danh sách địa chỉ thành công cho người dùng với Id {userId}");
			return _mapper.Map<IEnumerable<AddressDto>>(user.Addresses);
		}

		public async Task AddUserAddressAsync(int userId, AddressDto addressDto)
		{
			var user = await _userRepository.GetByIdAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			var address = _mapper.Map<Address>(addressDto);
			address.UserId = userId;

			user.Addresses.Add(address);
			await _userRepository.SaveChangesAsync();

			_logger.LogInfo($"Thêm địa chỉ mới thành công cho người dùng với Id {userId}");
		}

		public async Task SetDefaultAddressAsync(int userId, int addressId)
		{
			var user = await _userRepository.GetUserWithOrdersAsync(userId);
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			var address = user.Addresses.FirstOrDefault(a => a.Id == addressId);
			if (address == null)
			{
				_logger.LogError($"Không tìm thấy địa chỉ với Id {addressId}");
				throw new AddressNotFoundException(addressId);
			}

			foreach (var addr in user.Addresses)
			{
				addr.IsDefault = addr.Id == addressId;
			}

			await _userRepository.SaveChangesAsync();
			_logger.LogInfo($"Đặt địa chỉ mặc định thành công cho người dùng với Id {userId}");
		}

		public async Task<bool> ValidatePasswordAsync(int userId, string password)
		{
			var user = await _userManager.FindByIdAsync(userId.ToString());
			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với Id {userId}");
				throw new UserNotFoundException(userId);
			}

			var result = await _userManager.CheckPasswordAsync(user, password);
			_logger.LogInfo($"Kiểm tra mật khẩu thành công cho người dùng với Id {userId}");
			return result;
		}
	}
}
