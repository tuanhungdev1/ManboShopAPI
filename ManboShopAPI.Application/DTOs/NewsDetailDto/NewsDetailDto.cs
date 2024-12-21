using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.NewsDetailDto
{
	public class NewsDetailDto
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public decimal ProductPrice { get; set; }
		
	}
}
