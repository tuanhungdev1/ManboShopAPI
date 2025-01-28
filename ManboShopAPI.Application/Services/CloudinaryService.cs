using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using ManboShopAPI.Application.Common.Models;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Application.Common.Helpers;

namespace ManboShopAPI.Application.Services
{
	public class CloudinaryService : ICloudinaryService
	{
		private readonly Cloudinary _cloudinary;
		private readonly CloudinarySettings _cloudinarySettings;
		private readonly ILoggerService _logger;
		private readonly UserManager<User> _userManager;
		private readonly IUnitOfWork _unitOfWork;

		public CloudinaryService(IOptions<CloudinarySettings> cloudinarySettings,
								ILoggerService logger,
								UserManager<User> userManager,
								IUnitOfWork unitOfWork)
		{
			_cloudinarySettings = cloudinarySettings.Value;

			var acc = new Account(
				_cloudinarySettings.CloudName,
				_cloudinarySettings.ApiKey,
				_cloudinarySettings.ApiSecret);

			_cloudinary = new Cloudinary(acc);
			_logger = logger;
			_userManager = userManager;
			_unitOfWork = unitOfWork;
		}

		public async Task<string> UploadImageAsync(IFormFile file, string folder, string prefix)
		{
			FileHelper.ValidateFile(file);
			_logger.LogInfo($"Validated file. FileName: {file.FileName}, FileSize: {file.Length} bytes");
			var uniqueFileName = FileHelper.GenerateUniqueFileName(file.FileName, prefix);
			Console.WriteLine(uniqueFileName);
			using var stream = file.OpenReadStream();
			var uploadParams = new ImageUploadParams
			{
				File = new FileDescription(uniqueFileName, stream),
				Folder = folder,
			};

			var uploadResult = await _cloudinary.UploadAsync(uploadParams);

			return uploadResult.SecureUrl.ToString();
		}

		public async Task DeleteImageAsync(string publicId)
		{
			try
			{
				if (string.IsNullOrEmpty(publicId))
					throw new ArgumentNullException($"PublicId không được phép NULL!");
				var deleteParams = new DeletionParams(publicId);
				var result = await _cloudinary.DestroyAsync(deleteParams);

				if (result.Error != null)
				{
					_logger.LogError($"Có lỗi sảy ra khi xóa hình ảnh với PublicId: {publicId}, Error: {result.Error.Message}");
					throw new ArgumentNullException($"Không thể xóa một PublicId không tồn tại!");
				}
			}
			catch (Exception ex)
			{
				_logger.LogError($"Không thể xóa hình ảnh với PUBLIC_ID: {publicId}");
				throw ex;
			}
		}

		public async Task<string> ReplaceImageAsync(IFormFile newFile, string oldPublicId, string folder, string prefix)
		{
			string newImageUrl = await UploadImageAsync(newFile, folder, prefix);

			if (!string.IsNullOrEmpty(oldPublicId))
				await DeleteImageAsync(oldPublicId);

			return newImageUrl;
		}

		public string GetPublicIdFromUrl(string imageUrl)
		{
			try
			{
				var uri = new Uri(imageUrl);

				var segments = uri.AbsolutePath.Split('/');

				var uploadIndex = Array.IndexOf(segments, "upload");
				if (uploadIndex == -1 || uploadIndex + 2 >= segments.Length)
					return null;

				var startIndex = uploadIndex + 2;


				var publicId = string.Join("/", segments.Skip(startIndex)
												.Take(segments.Length - startIndex)).Replace(Path.GetExtension(segments.Last()), "");

				return publicId;
			}
			catch (Exception ex)
			{
				_logger.LogError("Có lỗi khi chuyển đổi Image URL sang PUBLIC_ID");
				return null;
			}
		}

		public async Task DeleteImagesAsync(List<string> imageUrls)
		{
			if (imageUrls == null || !imageUrls.Any())
				return;

			var failedDeletions = new List<string>();

			foreach (var imageUrl in imageUrls)
			{
				try
				{
					var publicId = GetPublicIdFromUrl(imageUrl);
					if (string.IsNullOrEmpty(publicId))
					{
						_logger.LogError($"Không thể lấy được PublicId từ URL: {imageUrl}");
						failedDeletions.Add(imageUrl);
						continue;
					}

					var deleteParams = new DeletionParams(publicId);
					var result = await _cloudinary.DestroyAsync(deleteParams);

					if (result.Error != null)
					{
						_logger.LogError($"Lỗi khi xóa ảnh với PublicId: {publicId}, Error: {result.Error.Message}");
						failedDeletions.Add(imageUrl);
					}
					else
					{
						_logger.LogInfo($"Đã xóa thành công ảnh với PublicId: {publicId}");
					}
				}
				catch (Exception ex)
				{
					_logger.LogError($"Lỗi không mong muốn khi xóa ảnh URL: {imageUrl}, Error: {ex.Message}");
					failedDeletions.Add(imageUrl);
				}
			}

			if (failedDeletions.Any())
			{
				_logger.LogWarning($"Có {failedDeletions.Count} ảnh không thể xóa khỏi Cloudinary");
				foreach (var url in failedDeletions)
				{
					_logger.LogWarning($"URL ảnh không thể xóa: {url}");
				}
			}
		}

		// Thêm phương thức để upload an toàn với tracking URLs
		public async Task<(string imageUrl, bool success)> SafeUploadImageAsync(IFormFile file, string folder, string prefix)
		{
			try
			{
				var imageUrl = await UploadImageAsync(file, folder, prefix);
				return (imageUrl, true);
			}
			catch (Exception ex)
			{
				_logger.LogError($"Lỗi khi upload ảnh: {ex.Message}");
				return (null, false);
			}
		}

	}
}
