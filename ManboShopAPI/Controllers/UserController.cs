﻿using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.UserDtos;
using ManboShopAPI.Domain.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class UsersController : ControllerBase
	{
		private readonly IUserService _userService;

		public UsersController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<UserDto>>> GetUsers([FromQuery] UserRequestParameters userRequestParameters)
		{
			var (users, metaData) = await _userService.GetUsersAsync(userRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách người dùng thành công.",
				Data = users,
				Pagination = metaData
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetUser))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<UserDto>> GetUser(int id)
		{
			var user = await _userService.GetUserByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu người dùng với Id {id} thành công.",
				Data = user
			});
		}

		[HttpGet("email/{email}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<UserDto>> GetUserByEmail(string email)
		{
			var user = await _userService.GetUserByEmailAsync(email);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu người dùng với email {email} thành công.",
				Data = user
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateUser([FromBody] UserForCreateDto userForCreateDto)
		{
			var user = await _userService.CreateUserAsync(userForCreateDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới người dùng thành công.",
				Data = user
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateUser(int id, [FromBody] UserForUpdateDto userForUpdateDto)
		{
			var user = await _userService.UpdateUserAsync(id, userForUpdateDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật người dùng với Id {id} thành công.",
				Data = user
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteUser(int id)
		{
			await _userService.DeleteUserAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa người dùng với Id {id} thành công."
			});
		}

		[HttpPost("{id:int}/changepassword")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> ChangePassword(int id, [FromBody] ChangePasswordDto changePasswordDto)
		{
			await _userService.ChangePasswordAsync(id, changePasswordDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Thay đổi mật khẩu thành công cho người dùng với Id {id}."
			});
		}
	}
}