using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.AddressDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Authorize]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class AddressController : ControllerBase
	{
		private readonly IAddressService _addressService;

		public AddressController(IAddressService addressService)
		{
			_addressService = addressService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<IEnumerable<AddressDto>>> GetUserAddresses()
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var addresses = await _addressService.GetUserAddressesAsync(userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách địa chỉ thành công.",
				Data = addresses
			});
		}

		[HttpGet("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<AddressDto>> GetAddress(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var address = await _addressService.GetAddressByIdAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy thông tin địa chỉ thành công.",
				Data = address
			});
		}

		[HttpGet("default")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<AddressDto>> GetDefaultAddress()
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var address = await _addressService.GetDefaultAddressAsync(userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy địa chỉ mặc định thành công.",
				Data = address
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<AddressDto>> CreateAddress([FromBody] AddressForCreateDto addressDto)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var address = await _addressService.CreateAddressAsync(userId, addressDto);

			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo địa chỉ mới thành công.",
				Data = address
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<AddressDto>> UpdateAddress(int id, [FromBody] AddressForUpdateDto addressDto)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var address = await _addressService.UpdateAddressAsync(id, userId, addressDto);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Cập nhật địa chỉ thành công.",
				Data = address
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteAddress(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			await _addressService.DeleteAddressAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Xóa địa chỉ thành công."
			});
		}

		[HttpPut("{id:int}/default")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<AddressDto>> SetDefaultAddress(int id)
		{
			var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var address = await _addressService.SetDefaultAddressAsync(id, userId);

			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Đặt địa chỉ mặc định thành công.",
				Data = address
			});
		}
	}
}
