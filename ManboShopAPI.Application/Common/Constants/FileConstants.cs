using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Constants
{
	public static class FileConstants
	{
		public static string folder = $"ManboShopAPI/";
		public static class FoldersName
		{
			public const string Products = "products";
			public const string Users = "users";
			public const string Categories = "categories";
			public const string Brand = "brands";
			public const string Banners = "banners";
		}

		public static class FileName
		{
			public const string ProductImage = "product_img";
			public const string UserAvatar = "avatar_img";
			public const string CategoryImage = "category_img";
			public const string BrandImage = "brand_img";
			public const string BannerImage = "banner_img";
		}
	}
}
