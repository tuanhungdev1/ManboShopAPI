using ManboShopAPI.Application.DTOs.BannerDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.BannerDetailDtos
{
	public class BannerDetailDto
	{
        public int Id { get; set; }
        public int ProductId { get; set; }
		public ProductDto Product { get; set; }
		public int BannerId { get; set; }
		public BannerDto Banner { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
    }
}
