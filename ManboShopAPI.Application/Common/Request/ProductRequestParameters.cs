using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Request
{
	public class ProductRequestParameters : RequestParameters
	{
        public int? BrandId { get; set; }
        public int? CategoryId { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public string? OrderPrice { get; set; }
    }
}
