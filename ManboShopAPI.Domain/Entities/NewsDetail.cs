using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class NewsDetail : BaseEntity
	{
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
