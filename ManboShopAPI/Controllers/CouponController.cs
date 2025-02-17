using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CouponDtos;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Authorize]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class CouponController : ControllerBase
	{
		private readonly ICouponService _couponService;

		public CouponController(ICouponService couponService)
		{
			_couponService = couponService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<CouponDto>>> GetAllCoupons(
			[FromQuery] CouponRequestParameters parameters)
		{
			var (coupons, metadata) = await _couponService.GetAllAsync(parameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách mã giảm giá thành công.",
				Data = coupons,
				Pagination = metadata
			});
		}

		[HttpGet("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CouponDto>> GetCouponById(int id)
		{
			var coupon = await _couponService.GetByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin mã giảm giá {id} thành công.",
				Data = coupon
			});
		}

		[HttpGet("code/{code}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CouponDto>> GetCouponByCode(string code)
		{
			var coupon = await _couponService.GetByCodeAsync(code);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin mã giảm giá '{code}' thành công.",
				Data = coupon
			});
		}

		[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<ActionResult<CouponDto>> CreateCoupon([FromBody] CouponForCreateDto couponDto)
		{
			var coupon = await _couponService.CreateAsync(couponDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mã giảm giá thành công.",
				Data = coupon
			});
		}

		[HttpPut("{id:int}")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<CouponDto>> UpdateCoupon(
			int id,
			[FromBody] CouponForUpdateDto couponDto)
		{
			var coupon = await _couponService.UpdateAsync(id, couponDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật mã giảm giá {id} thành công.",
				Data = coupon
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteCoupon(int id)
		{
			await _couponService.DeleteAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa mã giảm giá {id} thành công."
			});
		}

		[HttpPost("validate")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<bool>> ValidateCoupon(
			[FromBody] ValidateCouponDto request)
		{
			var isValid = await _couponService.ValidateCouponAsync(request.Code, request.OrderAmount);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = isValid
					? "Mã giảm giá hợp lệ."
					: "Mã giảm giá không hợp lệ.",
				Data = isValid
			});
		}

		[HttpPost("calculate-discount")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<decimal>> CalculateDiscount(
			[FromBody] CalculateDiscountDto request)
		{
			var discountAmount = await _couponService.CalculateDiscountAsync(
				request.Code,
				request.OrderAmount
			);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Tính toán giảm giá thành công.",
				Data = discountAmount
			});
		}
	}
}
