﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.BannerDetailDtos
{
	public class BannerDetailForUpdateDto
	{
		[Required(ErrorMessage = "Id banner không được để trống")]
		public int BannerId { get; set; }
		[Required(ErrorMessage = "Id sản phẩm không được để trống")]
		public int ProductId { get; set; }
	}
}