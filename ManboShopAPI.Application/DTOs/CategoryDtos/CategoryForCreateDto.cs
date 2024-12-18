using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CategoryDtos
{
	public class CategoryForCreateDto
	{
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
		public string? ImageUrl { get; set; }
	}
}
