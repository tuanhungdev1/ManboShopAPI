﻿namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public sealed class BannerNotFoundException : NotFoundException
	{
		public BannerNotFoundException(int brandId)
		: base($"Không tìm thấy thương hiệu với Id: {brandId} tồn tại trong cơ sở dữ liệu.")
		{
		}

		public BannerNotFoundException(string message) : base(message)
		{

		}
	}
}
