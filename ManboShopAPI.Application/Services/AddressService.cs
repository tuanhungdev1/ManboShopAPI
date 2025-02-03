using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class AddressService : IAddressService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public AddressService(
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId)
		{
			var addresses = await _unitOfWork.AddressRepository.GetAddressesByUserIdAsync(userId, true);
			return _mapper.Map<IEnumerable<AddressDto>>(addresses);
		}

		public async Task<AddressDto> GetAddressByIdAsync(int addressId, int userId)
		{
			var address = await _unitOfWork.AddressRepository.GetAddressWithUserAsync(addressId, true);

			if (address == null)
				throw new AddressNotFoundException($"Không tìm thấy địa chỉ {addressId}");

			if (address.UserId != userId)
				throw new UnauthorizedAccessException("Bạn không có quyền truy cập địa chỉ này");

			return _mapper.Map<AddressDto>(address);
		}

		public async Task<AddressDto> GetDefaultAddressAsync(int userId)
		{
			var address = await _unitOfWork.AddressRepository.GetDefaultAddressForUserAsync(userId, true);

			if (address == null)
				throw new AddressNotFoundException($"Không tìm thấy địa chỉ mặc định cho người dùng {userId}");

			return _mapper.Map<AddressDto>(address);
		}

		public async Task<AddressDto> CreateAddressAsync(int userId, AddressForCreateDto addressDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var address = _mapper.Map<Address>(addressDto);
				address.UserId = userId;

				var addressCount = await _unitOfWork.AddressRepository.GetUserAddressCountAsync(userId);

				if (addressDto.IsDefault || addressCount == 0)
				{
					// Nếu có địa chỉ mặc định trước đó, cần đặt nó thành false
					var defaultAddress = await _unitOfWork.AddressRepository
											.FindByCondition(a => a.UserId == userId && a.IsDefault)
											.AsTracking()
											.SingleOrDefaultAsync();

					if (defaultAddress != null)
					{
						defaultAddress.IsDefault = false;
						_unitOfWork.AddressRepository.Update(defaultAddress);
					}

					address.IsDefault = true;
				}

				await _unitOfWork.AddressRepository.AddAsync(address);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Tạo địa chỉ mới thành công cho người dùng {userId}");
				return _mapper.Map<AddressDto>(address);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}


		public async Task<AddressDto> UpdateAddressAsync(int addressId, int userId, AddressForUpdateDto addressDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var address = await _unitOfWork.AddressRepository.GetByIdAsync(addressId);
				if (address == null)
					throw new AddressNotFoundException($"Không tìm thấy địa chỉ {addressId}");

				if (address.UserId != userId)
					throw new UnauthorizedAccessException("Bạn không có quyền cập nhật địa chỉ này");

				if (addressDto.IsDefault && !address.IsDefault)
				{
					// Tìm địa chỉ mặc định cũ và đặt lại thành false
					var defaultAddress = await _unitOfWork.AddressRepository
											.FindByCondition(a => a.UserId == userId && a.IsDefault)
											.AsTracking()
											.SingleOrDefaultAsync();

					if (defaultAddress != null)
					{
						defaultAddress.IsDefault = false;
						_unitOfWork.AddressRepository.Update(defaultAddress);
					}

					address.IsDefault = true;
				}

				_mapper.Map(addressDto, address);

				_unitOfWork.AddressRepository.Update(address);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Cập nhật địa chỉ {addressId} thành công");
				return _mapper.Map<AddressDto>(address);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}


		public async Task DeleteAddressAsync(int addressId, int userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var address = await _unitOfWork.AddressRepository.GetByIdAsync(addressId);
				if (address == null)
					throw new AddressNotFoundException($"Không tìm thấy địa chỉ {addressId}");

				if (address.UserId != userId)
					throw new UnauthorizedAccessException("Bạn không có quyền xóa địa chỉ này");

				// Kiểm tra nếu địa chỉ là mặc định, không cho phép xóa
				if (address.IsDefault)
				{
					throw new AddressBadRequestException("Không thể xóa địa chỉ mặc định");
				}

				var addressCount = await _unitOfWork.AddressRepository.GetUserAddressCountAsync(userId);
				if (addressCount == 1)
					throw new AddressBadRequestException("Không thể xóa địa chỉ duy nhất");

				_unitOfWork.AddressRepository.Remove(address);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Xóa địa chỉ {addressId} thành công");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}


		public async Task<AddressDto> SetDefaultAddressAsync(int addressId, int userId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				if (!await _unitOfWork.AddressRepository.IsAddressOwnerAsync(addressId, userId))
					throw new UnauthorizedAccessException("Bạn không có quyền cập nhật địa chỉ này");

				await _unitOfWork.AddressRepository.SetDefaultAddressAsync(addressId, userId);
				await _unitOfWork.CommitAsync();

				var address = await _unitOfWork.AddressRepository.GetByIdAsync(addressId);
				_logger.LogInfo($"Đặt địa chỉ {addressId} làm mặc định thành công");

				return _mapper.Map<AddressDto>(address);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}
	}
}
