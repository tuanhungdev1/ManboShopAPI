

using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CouponDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;

namespace ManboShopAPI.Application.Services
{
	public class CouponService : ICouponService
	{
		private readonly ICouponRepository _couponRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public CouponService(
			ICouponRepository couponRepository,
			IMapper mapper,
			ILoggerService logger)
		{
			_couponRepository = couponRepository;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<CouponDto> GetByIdAsync(int id)
		{
			var coupon = await _couponRepository.GetByIdAsync(id);
			if (coupon == null)
				throw new CouponNotFoundException(id);

			return _mapper.Map<CouponDto>(coupon);
		}

		public async Task<CouponDto> GetByCodeAsync(string code)
		{
			var coupon = await _couponRepository.GetByCodeAsync(code);
			if (coupon == null)
				throw new CouponNotFoundException($"Không tìm thấy mã giảm giá '{code}'");

			return _mapper.Map<CouponDto>(coupon);
		}

		public async Task<(IEnumerable<CouponDto> coupons, MetaData metaData)> GetAllAsync(
			CouponRequestParameters parameters)
		{
			var coupons = await _couponRepository.GetAllCouponsAsync(parameters);
			var couponDtos = _mapper.Map<IEnumerable<CouponDto>>(coupons);
			return (coupons: couponDtos, metaData: coupons.MetaData);
		}

		public async Task<CouponDto> CreateAsync(CouponForCreateDto couponDto)
		{
			if (await _couponRepository.CodeExistsAsync(couponDto.Code))
				throw new CouponBadRequestException($"Mã giảm giá '{couponDto.Code}' đã tồn tại");

			if (couponDto.EndDate <= couponDto.StartDate)
				throw new CouponBadRequestException("Ngày kết thúc phải sau ngày bắt đầu");

			if (couponDto.DiscountType == DiscountType.Percentage && couponDto.DiscountValue > 100)
				throw new CouponBadRequestException("Giá trị giảm giá theo phần trăm không được vượt quá 100%");

			var coupon = _mapper.Map<Coupon>(couponDto);
			await _couponRepository.AddAsync(coupon);
			await _couponRepository.SaveChangesAsync();

			return _mapper.Map<CouponDto>(coupon);
		}

		public async Task<CouponDto> UpdateAsync(int id, CouponForUpdateDto couponDto)
		{
			var coupon = await _couponRepository.GetByIdAsync(id);
			if (coupon == null)
				throw new CouponNotFoundException(id);

			if (couponDto.StartDate.HasValue && couponDto.EndDate.HasValue &&
				couponDto.EndDate <= couponDto.StartDate)
				throw new CouponBadRequestException("Ngày kết thúc phải sau ngày bắt đầu");

			// Update properties
			if (couponDto.Description != null)
				coupon.Description = couponDto.Description;
			if (couponDto.StartDate.HasValue)
				coupon.StartDate = couponDto.StartDate.Value;
			if (couponDto.EndDate.HasValue)
				coupon.EndDate = couponDto.EndDate.Value;
			if (couponDto.MaxUsage.HasValue)
				coupon.MaxUsage = couponDto.MaxUsage;
			if (couponDto.MinimumAmount.HasValue)
				coupon.MinimumAmount = couponDto.MinimumAmount;
			if (couponDto.MaximumDiscountAmount.HasValue)
				coupon.MaximumDiscountAmount = couponDto.MaximumDiscountAmount;
			if (couponDto.IsActive.HasValue)
				coupon.IsActive = couponDto.IsActive.Value;

			_couponRepository.Update(coupon);
			await _couponRepository.SaveChangesAsync();

			return _mapper.Map<CouponDto>(coupon);
		}

		public async Task DeleteAsync(int id)
		{
			var coupon = await _couponRepository.GetByIdAsync(id);
			if (coupon == null)
				throw new CouponNotFoundException(id);

			_couponRepository.Remove(coupon);
			await _couponRepository.SaveChangesAsync();
		}

		public async Task<decimal> CalculateDiscountAsync(string code, decimal orderAmount)
		{
			var coupon = await _couponRepository.GetByCodeAsync(code);
			if (coupon == null)
				throw new CouponNotFoundException($"Không tìm thấy mã giảm giá '{code}'");

			if (!await ValidateCouponAsync(code, orderAmount))
				throw new CouponBadRequestException("Mã giảm giá không hợp lệ");

			decimal discountAmount;
			if (coupon.DiscountType == DiscountType.Percentage)
			{
				discountAmount = orderAmount * (coupon.DiscountValue / 100);
				if (coupon.MaximumDiscountAmount.HasValue)
					discountAmount = Math.Min(discountAmount, coupon.MaximumDiscountAmount.Value);
			}
			else
			{
				discountAmount = coupon.DiscountValue;
			}

			return discountAmount;
		}

		public async Task<bool> ValidateCouponAsync(string code, decimal orderAmount)
		{
			var coupon = await _couponRepository.GetByCodeAsync(code);
			if (coupon == null)
				return false;

			var now = DateTime.UtcNow;
			return coupon.IsActive &&
				   now >= coupon.StartDate &&
				   now <= coupon.EndDate &&
				   (!coupon.MaxUsage.HasValue || coupon.UsageCount < coupon.MaxUsage) &&
				   (!coupon.MinimumAmount.HasValue || orderAmount >= coupon.MinimumAmount);
		}
	}
}
