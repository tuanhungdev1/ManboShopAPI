using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class ProductImage : BaseEntity
	{
        public required string ImageUrl { get; set; }
        public required int ProductId { get; set; }
        public required Product Product { get; set; }
    }
}
