﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CategoryDtos
{
	public class CategoryForCreateDto
	{
		[Required(ErrorMessage = "Tên danh mục không được để trống")]
		[MaxLength(100, ErrorMessage = "Tên danh mục không được vượt quá 100 ký tự")]
		public required string Name { get; set; }
		public string? ImageUrl { get; set; }
	}
}
