using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class Category : BaseEntity
	{
		[Required]
		[MaxLength(100)]
        public required string Name { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
