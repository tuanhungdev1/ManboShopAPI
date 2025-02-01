using ManboShopAPI.Application.DTOs.AddressDtos;

namespace ManboShopAPI.Application.Contracts
{
	public interface IAddressService
	{
		Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId);
		Task<AddressDto> GetAddressByIdAsync(int addressId, int userId);
		Task<AddressDto> GetDefaultAddressAsync(int userId);
		Task<AddressDto> CreateAddressAsync(int userId, AddressForCreateDto addressDto);
		Task<AddressDto> UpdateAddressAsync(int addressId, int userId, AddressForUpdateDto addressDto);
		Task DeleteAddressAsync(int addressId, int userId);
		Task<AddressDto> SetDefaultAddressAsync(int addressId, int userId);
	}
}
