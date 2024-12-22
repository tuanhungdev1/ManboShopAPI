using ManboShopAPI.Application.DTOs.NewsDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.NewsDetailDto
{
	public class NewsDetailDto
	{
		public int Id { get; set; }
		public int ProductId { get; set; }
		public int NewsId { get; set; }
		public ProductDto Product { get; set; }
		public NewsDto News { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
