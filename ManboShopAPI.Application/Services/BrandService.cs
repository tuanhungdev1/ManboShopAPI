using AutoMapper;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class BrandService : IBrandService
	{
		private readonly IBrandRepository _brandRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public BrandService(IBrandRepository brandRepository,
								IMapper mapper,
								ILoggerService loggerService
								)
		{
			_brandRepository = brandRepository;
			_mapper = mapper;
			_logger = loggerService;
		}


		public async Task<(IEnumerable<BrandDto> categories, MetaData metaData)> GetAllBrandAsync(BrandRequestParameters brandRequestParameters)
		{
			var brands = await _brandRepository.FetchAllCategoriesWithPaging(brandRequestParameters);
			_logger.LogInfo("Lấy danh sách thường hiệu thành công.");
			var brandDtoList = _mapper.Map<IEnumerable<BrandDto>>(brands);
			return (brandDtoList, metaData: brands.MetaData);
		}

		public async Task<BrandDto> GetBrandByIdAsync(int brandId)
		{
			var brand = await _brandRepository.GetByIdAsync(brandId);
			if (brand == null)
			{
				_logger.LogError($"Không tìm thấy thương hiệu với Id {brandId}");
				throw new BrandNotFoundException(brandId);
			}
			_logger.LogInfo($"Lấy dữ liệu thương hiệu thành công.");
			return _mapper.Map<BrandDto>(brand);
		}

		public async Task CreateBrandAsync(BrandForCreateDto brandForCreateDto)
		{
			bool isBrandExisting = await _brandRepository.BrandExistsAsync(brandForCreateDto.Name);

			if(isBrandExisting)
			{
				_logger.LogError($"Tên thương hiệu {brandForCreateDto.Name} đã tồn tại trong hệ thống.");
				throw new BrandBadRequestException($"Tên thương hiệu {brandForCreateDto.Name} đã tồn tại trong hệ thống.");
			}

			var brand = _mapper.Map<Brand>(brandForCreateDto);
			await _brandRepository.AddAsync(brand);
			await _brandRepository.SaveChangesAsync();
			_logger.LogInfo("Tạo thương hiệu mới thành công.");
		}

		public async Task UpdateBrandAsync(int brandId, BrandForUpdateDto brandForUpdateDto)
		{

			var existingBrand = await _brandRepository.GetByIdAsync(brandId);
			if (existingBrand == null)
			{
				_logger.LogError($"Không tìm thấy thương hiệu với Id {brandId}");
				throw new BrandNotFoundException(brandId);
			}

			if (existingBrand.Name == brandForUpdateDto.Name ||
				await BrandExistsAsync(brandForUpdateDto.Name))
			{
				_logger.LogError($"Tên thương hiệu {brandForUpdateDto.Name} đã tồn tại trong hệ thống.");
				throw new BrandBadRequestException($"Tên thương hiệu {brandForUpdateDto.Name} đã tồn tại trong hệ thống.");
			}

			_mapper.Map(brandForUpdateDto, existingBrand);
			existingBrand.UpdatedAt = DateTime.UtcNow;
			_brandRepository.Update(existingBrand);
			await _brandRepository.SaveChangesAsync();
			_logger.LogInfo($"Cập nhật thành công thương hiệu với Id {existingBrand.Id}");
		}

		public async Task DeleteBrandAsync(int brandId)
		{
			var existingBrand = await _brandRepository.GetByIdAsync(brandId);
			if (existingBrand == null)
			{
				_logger.LogError($"Không tìm thấy thương hiệu với Id {brandId}");
				throw new BrandNotFoundException(brandId);
			}

			_brandRepository.Remove(existingBrand);
			await _brandRepository.SaveChangesAsync();
			_logger.LogInfo($"Xóa thành công thương hiệu với Id {existingBrand.Id}");
		}

		public async Task<bool> BrandExistsAsync(string brandName)
		{
			return await _brandRepository.BrandExistsAsync(brandName);
		}

		public async Task<BrandDto> GetBrandByNameAsync(string brandName)
		{
			var brand = await _brandRepository
										.FindByCondition(c => c.Name == brandName)
										.FirstOrDefaultAsync();
			if (brand == null)
			{
				_logger.LogError($"Không tìm thấy thương hiệu với tên là {brandName}.");
				throw new BrandNotFoundException($"Không tìm thấy thương hiệu với tên là {brandName}.");
			}
			var brandDto = _mapper.Map<BrandDto>(brand);
			_logger.LogInfo($"Lấy dữ liệu thành công thương hiệu với tên là {brandName}");
			return brandDto;
		}
	}
}
