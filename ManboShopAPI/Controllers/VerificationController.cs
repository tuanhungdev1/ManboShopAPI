using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.VerificationDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class VerificationController : ControllerBase
	{
		private readonly IVerificationService _verificationService;

		public VerificationController(IVerificationService verificationService)
		{
			_verificationService = verificationService;
		}

		[HttpPost("send-code")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<IActionResult> SendVerificationCode([FromBody] EmailVerificationDto emailVerificationDto)
		{
			await _verificationService.SendVerificationCodeAsync(emailVerificationDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Mã xác thực đã được gửi thành công"
			});
		}

		[HttpPost("verify")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> VerifyCode([FromBody] VerificationRequestDto verificationRequestDto)
		{
			var( userDto, tokenDto) = await _verificationService.VerifyCodeAsync(verificationRequestDto);
			
			var token = new Token
			{
				AssessToken = tokenDto.AccessToken,
				RefreshToken = tokenDto.RefreshToken
			};
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Xác thực thành công",
				Data = userDto,
				Token = token
			});
		}
	}
}
