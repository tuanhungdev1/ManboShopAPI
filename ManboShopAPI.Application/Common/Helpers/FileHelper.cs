using ManboShopAPI.Domain.Exceptions.BadRequest;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Helpers
{
	public static class FileHelper
	{
		private static readonly string[] AllowedImageExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
		private const int MaxFileSizeInMB = 5;
		private const int MaxFileSizeInBytes = MaxFileSizeInMB * 1024 * 1024; // 5MB

		public static void ValidateFile(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				throw new FileBadRequestException("File không được để trống");
			}

			var fileExtension = Path.GetExtension(file.FileName).ToLower();

			// Kiểm tra định dạng file
			if (!AllowedImageExtensions.Contains(fileExtension))
			{
				throw new FileBadRequestException(
					$"Định dạng file không được hỗ trợ. Chỉ chấp nhận các định dạng: {string.Join(", ", AllowedImageExtensions)}"
				);
			}

			// Kiểm tra kích thước file
			if (file.Length > MaxFileSizeInBytes)
			{
				throw new FileBadRequestException(
					$"Kích thước file vượt quá giới hạn cho phép ({MaxFileSizeInMB}MB)"
				);
			}
		}

		public static string GenerateUniqueFileName(string originalFileName, string prefix)
		{
			var fileExtension = Path.GetExtension(originalFileName);
			var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(originalFileName);

			// Loại bỏ các ký tự đặc biệt và khoảng trắng từ tên file
			fileNameWithoutExtension = SanitizeFileName(fileNameWithoutExtension);

			// Tạo tên file theo format: prefix_filename_timestamp.extension
			var timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmss");
			var uniqueFileName = $"{prefix}_{fileNameWithoutExtension}_{timestamp}{fileExtension}";

			return uniqueFileName.ToLower();
		}

		private static string SanitizeFileName(string fileName)
		{
			// Loại bỏ các ký tự không hợp lệ từ tên file
			var invalidChars = Path.GetInvalidFileNameChars()
				.Concat(new char[] { ' ', ',', '.', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=' })
				.ToArray();

			// Thay thế các ký tự không hợp lệ bằng dấu gạch ngang
			var sanitizedFileName = string.Join("_", fileName.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));

			// Đảm bảo tên file không quá dài
			const int maxFileNameLength = 50;
			if (sanitizedFileName.Length > maxFileNameLength)
			{
				sanitizedFileName = sanitizedFileName.Substring(0, maxFileNameLength);
			}

			return sanitizedFileName;
		}

		public static bool IsImageFile(string fileName)
		{
			if (string.IsNullOrEmpty(fileName))
				return false;

			var extension = Path.GetExtension(fileName).ToLower();
			return AllowedImageExtensions.Contains(extension);
		}
	}
}
