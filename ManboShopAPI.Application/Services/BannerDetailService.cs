using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BannerDetailDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class BannerDetailService : IBannerDetailService
	{
		private readonly IBannerDetailRepository _bannerDetailRepository;
		private readonly IBannerRepository _bannerRepository;
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public BannerDetailService(
			IBannerDetailRepository bannerDetailRepository,
			IBannerRepository bannerRepository,
			IProductRepository productRepository,
			IMapper mapper,
			ILoggerService logger)
		{
			_bannerDetailRepository = bannerDetailRepository;
			_bannerRepository = bannerRepository;
			_productRepository = productRepository;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<BannerDetailDto> GetBannerDetailByIdAsync(int bannerDetailId)
		{
			var bannerDetail = await _bannerDetailRepository
				.FindByCondition(bd => bd.Id == bannerDetailId)
				.Include(bd => bd.Banner)
				.Include(bd => bd.Product)
				.FirstOrDefaultAsync()
				;
			if (bannerDetail == null)
			{
				_logger.LogError($"Không tìm thấy chi tiết banner với Id {bannerDetailId}");
				throw new BannerDetailNotFoundException(bannerDetailId);
			}

			_logger.LogInfo($"Lấy chi tiết banner thành công.");
			return _mapper.Map<BannerDetailDto>(bannerDetail);
		}

		public async Task<IEnumerable<BannerDetailDto>> GetAllBannerDetailAsync()
		{
			var bannerDetails = await _bannerDetailRepository
				.FindByCondition(x => true)
				.Include(bd => bd.Banner)
				.Include(bd => bd.Product)
				.ToListAsync()
				;
			_logger.LogInfo("Lấy danh sách chi tiết banner thành công.");
			return _mapper.Map<IEnumerable<BannerDetailDto>>(bannerDetails);
		}

		public async Task UpdateBannerDetailAsync(int bannerDetailId, BannerDetailForUpdateDto bannerDetailForUpdateDto)
		{
			var bannerDetail = await _bannerDetailRepository.GetByIdAsync(bannerDetailId);
			if (bannerDetail == null)
			{
				_logger.LogError($"Không tìm thấy chi tiết banner với Id {bannerDetailId}");
				throw new BannerDetailNotFoundException(bannerDetailId);
			}
				
			var banner = await _bannerRepository.GetByIdAsync(bannerDetailForUpdateDto.BannerId);
			if (banner == null)
			{
				_logger.LogError($"Không tìm thấy banner với Id {bannerDetailForUpdateDto.BannerId}");
				throw new BannerNotFoundException(bannerDetailForUpdateDto.BannerId);
			}

			var product = await _productRepository.GetByIdAsync(bannerDetailForUpdateDto.ProductId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với Id {bannerDetailForUpdateDto.ProductId}");
				throw new ProductNotFoundException(bannerDetailForUpdateDto.ProductId);
			}

			var existingBannerDetail = await _bannerDetailRepository
				.FindByCondition(x => x.Id != bannerDetailId && x.BannerId == bannerDetailForUpdateDto.BannerId && x.ProductId == bannerDetailForUpdateDto.ProductId)
				.ToListAsync();

			if (existingBannerDetail.Count > 0)
			{
				_logger.LogError($"Chi tiết banner đã tồn tại với BannerId {bannerDetailForUpdateDto.BannerId} và ProductId {bannerDetailForUpdateDto.ProductId}");
				throw new BannerDetailBadRequestException($"Chi tiết banner đã tồn tại.");
			}

			_mapper.Map(bannerDetailForUpdateDto, bannerDetail);

			_bannerDetailRepository.Update(bannerDetail);
			await _bannerDetailRepository.SaveChangesAsync();

			_logger.LogInfo("Cập nhật chi tiết banner thành công.");
		} 

		public async Task<IEnumerable<BannerDetailDto>> GetBannerDetailsByBannerIdAsync(int bannerId)
		{
			var banner = await _bannerRepository.GetByIdAsync(bannerId);
			if (banner == null)
			{
				_logger.LogError($"Không tìm thấy banner với Id {bannerId}");
				throw new BannerNotFoundException(bannerId);
			}

			var bannerDetails = await _bannerDetailRepository.GetBannerDetailsByBannerIdAsync(bannerId, true);
			_logger.LogInfo($"Lấy danh sách chi tiết banner với Id {bannerId} thành công.");
			return _mapper.Map<IEnumerable<BannerDetailDto>>(bannerDetails);
		}

		public async Task<IEnumerable<BannerDetailDto>> GetBannerDetailsByProductIdAsync(int productId)
		{
			var product = await _productRepository.GetByIdAsync(productId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với Id {productId}");
				throw new ProductNotFoundException(productId);
			}

			var bannerDetails = await _bannerDetailRepository.GetBannerDetailsByProductIdAsync(productId, true);
			_logger.LogInfo($"Lấy danh sách chi tiết banner cho sản phẩm Id {productId} thành công.");
			return _mapper.Map<IEnumerable<BannerDetailDto>>(bannerDetails);
		}

		public async Task<BannerDetailDto> GetBannerDetailAsync(int bannerId, int productId)
		{
			var bannerDetail = await _bannerDetailRepository.GetBannerDetailAsync(bannerId, productId, true);
			if (bannerDetail == null)
			{
				_logger.LogError($"Không tìm thấy chi tiết banner với BannerId {bannerId} và ProductId {productId}");
				throw new BannerDetailNotFoundException(bannerId, productId);
			}

			_logger.LogInfo($"Lấy chi tiết banner thành công.");
			return _mapper.Map<BannerDetailDto>(bannerDetail);
		}

		public async Task CreateBannerDetailAsync(BannerDetailForCreateDto bannerDetailForCreateDto)
		{
			var banner = await _bannerRepository.GetByIdAsync(bannerDetailForCreateDto.BannerId);
			if (banner == null)
			{
				_logger.LogError($"Không tìm thấy banner với Id {bannerDetailForCreateDto.BannerId}");
				throw new BannerNotFoundException(bannerDetailForCreateDto.BannerId);
			}

			var product = await _productRepository.GetByIdAsync(bannerDetailForCreateDto.ProductId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với Id {bannerDetailForCreateDto.ProductId}");
				throw new ProductNotFoundException(bannerDetailForCreateDto.ProductId);
			}

			var isExists = await _bannerDetailRepository.IsBannerDetailExistAsync(
				bannerDetailForCreateDto.BannerId,
				bannerDetailForCreateDto.ProductId);
			if (isExists)
			{
				_logger.LogError($"Chi tiết banner đã tồn tại với BannerId {bannerDetailForCreateDto.BannerId} và ProductId {bannerDetailForCreateDto.ProductId}");
				throw new BannerDetailBadRequestException($"Chi tiết banner đã tồn tại.");
			}

			var bannerDetail = _mapper.Map<BannerDetail>(bannerDetailForCreateDto);
			await _bannerDetailRepository.AddAsync(bannerDetail);
			await _bannerDetailRepository.SaveChangesAsync();

			_logger.LogInfo("Tạo chi tiết banner mới thành công.");
		}

		public async Task DeleteBannerDetailAsync(int bannerDetailId)
		{
			var bannerDetail = await _bannerDetailRepository.GetByIdAsync(bannerDetailId);
			if (bannerDetail == null)
			{
				_logger.LogError($"Không tìm thấy chi tiết banner với Id {bannerDetailId}");
				throw new BannerDetailNotFoundException(bannerDetailId);
			}

			_bannerDetailRepository.Remove(bannerDetail);
			await _bannerDetailRepository.SaveChangesAsync();

			_logger.LogInfo($"Xóa chi tiết banner thành công.");
		}
	}
}