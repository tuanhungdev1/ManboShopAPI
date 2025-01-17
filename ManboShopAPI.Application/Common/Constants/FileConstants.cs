using System;

namespace ManboShopAPI.Application.Common.Constants
{
	public static class FileConstants
	{
		public static readonly string BaseFolder = "ARISTINO/";

		public static class FolderNames
		{
			public const string Products = "products";
			public const string Users = "users";
			public const string Categories = "categories";
			public const string Brands = "brands";
			public const string Banners = "banners";
		}

		public static class FileNames
		{
			public const string ProductImage = "product_img";
			public const string UserAvatar = "avatar_img";
			public const string CategoryImage = "category_img";
			public const string BrandImage = "brand_img";
			public const string BannerImage = "banner_img";
		}

		
		public static string GetFullPath(string folderName, string? fileName)
		{
			if (string.IsNullOrWhiteSpace(folderName))
				throw new ArgumentException("Folder name cannot be null or empty.", nameof(folderName));

			return fileName != null ? $"{BaseFolder}{folderName}/{fileName}" : $"{BaseFolder}{folderName}/";
		}
	}
}
