using AutoMapper;
using ManboShopAPI.Application.Common.Constants;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BannerDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class BannerService : IBannerService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;
		private readonly ICloudinaryService _cloudinaryService;

		public BannerService(
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger,
			ICloudinaryService cloudinaryService)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
			_logger = logger;
			_cloudinaryService = cloudinaryService;
		}

		public async Task<(IEnumerable<BannerDto> bannerDtos, MetaData metaData)> GetAllBannersAsync(BannerRequestParameters bannerRequestParameters)
		{
			var banners = await _unitOfWork.BannerRepository.FetchAllBannerAsync(bannerRequestParameters);
			_logger.LogInfo("Lấy danh sách banner thành công.");
			var bannerDtoList = _mapper.Map<IEnumerable<BannerDto>>(bannerRequestParameters);
			return (bannerDtoList, banners.MetaData);
		}

		public async Task<BannerDto> GetBannerByIdAsync(int bannerId)
		{
			var banner = await _unitOfWork.BannerRepository.GetBannerWithDetailsAsync(bannerId, true);
			if (banner == null)
			{
				_logger.LogError($"Không tìm thấy banner với Id {bannerId}");
				throw new BannerNotFoundException($"Không tìm thấy banner với Id {bannerId}");
			}
			_logger.LogInfo($"Lấy dữ liệu banner thành công.");
			return _mapper.Map<BannerDto>(banner);
		}

		public async Task CreateBannerAsync(BannerForCreateDto bannerForCreateDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				bool isBannerExisting = await _unitOfWork.BannerRepository.IsBannerExistAsync(bannerForCreateDto.Name);
				if (isBannerExisting)
				{
					_logger.LogError($"Banner {bannerForCreateDto.Name} đã tồn tại trong hệ thống.");
					throw new BannerBadRequestException($"Banner {bannerForCreateDto.Name} đã tồn tại trong hệ thống.");
				}

				// Upload image to Cloudinary
				string folder = $"HomeDecor/{FileConstants.FoldersName.Banners}/";
				string imageUrl = await _cloudinaryService.UploadImageAsync(
					bannerForCreateDto.BannerImage,
					folder,
					FileConstants.FileName.BannerImage);

				var banner = _mapper.Map<Banner>(bannerForCreateDto);
				banner.ImageUrl = imageUrl;

				await _unitOfWork.BannerRepository.AddAsync(banner);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo("Tạo banner mới thành công.");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task UpdateBannerAsync(int bannerId, BannerForUpdateDto bannerForUpdateDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var existingBanner = await _unitOfWork.BannerRepository.GetByIdAsync(bannerId);
				if (existingBanner == null)
				{
					_logger.LogError($"Không tìm thấy banner với Id {bannerId}");
					throw new BannerNotFoundException($"Không tìm thấy banner với Id {bannerId}");
				}

				if (existingBanner.Name != bannerForUpdateDto.Name &&
					await _unitOfWork.BannerRepository.IsBannerExistAsync(bannerForUpdateDto.Name))
				{
					_logger.LogError($"Banner {bannerForUpdateDto.Name} đã tồn tại trong hệ thống.");
					throw new BannerBadRequestException($"Banner {bannerForUpdateDto.Name} đã tồn tại trong hệ thống.");
				}

				// Update image if provided
				if (bannerForUpdateDto.BannerImage != null)
				{
					string folder = $"HomeDecor/{FileConstants.FoldersName.Banners}/";
					string oldPublicId = _cloudinaryService.GetPublicIdFromUrl(existingBanner.ImageUrl);
					string newImageUrl = await _cloudinaryService.ReplaceImageAsync(
						bannerForUpdateDto.BannerImage,
						oldPublicId,
						folder,
						FileConstants.FileName.BannerImage);
					existingBanner.ImageUrl = newImageUrl;

					_logger.LogInfo("Upload File Banner lên Cloudinary thành công");
				}

				_mapper.Map(bannerForUpdateDto, existingBanner);
				existingBanner.UpdatedAt = DateTime.UtcNow;
				_unitOfWork.BannerRepository.Update(existingBanner);

				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Cập nhật thành công banner với Id {bannerId}");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task DeleteBannerAsync(int bannerId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var existingBanner = await _unitOfWork.BannerRepository.GetByIdAsync(bannerId);
				if (existingBanner == null)
				{
					_logger.LogError($"Không tìm thấy banner với Id {bannerId}");
					throw new BannerNotFoundException($"Không tìm thấy banner với Id {bannerId}");
				}

				// Delete image from Cloudinary
				string publicId = _cloudinaryService.GetPublicIdFromUrl(existingBanner.ImageUrl);
				if (!string.IsNullOrEmpty(publicId))
				{
					await _cloudinaryService.DeleteImageAsync(publicId);
					_logger.LogInfo("Xóa ảnh Banner trên Cloudinary thành công");
				}

				_unitOfWork.BannerRepository.Remove(existingBanner);
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Xóa thành công banner với Id {bannerId}");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}

		public async Task<IEnumerable<BannerDto>> GetActiveBannersAsync()
		{
			var banners = await _unitOfWork.BannerRepository.GetActiveBannersAsync(true);
			_logger.LogInfo("Lấy danh sách banner đang hoạt động thành công.");
			return _mapper.Map<IEnumerable<BannerDto>>(banners);
		}
	}
}