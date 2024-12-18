using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class Product : BaseEntity
	{
		[Required]
		[MaxLength(100)]
        public required string Name { get; set; }
		[Required]
		[MaxLength(1000)]
		public required string Description { get; set; }
		public string? Specification { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }
		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal OldPrice { get; set; }
		[Range(0, int.MaxValue)]
		public int BuyTurn { get; set; } = 0;
		[Required]
		[Range(0, int.MaxValue)]
		public int Quantity { get; set; }
		[ForeignKey("Category")]
		public int? CategoryId { get; set; }
		[ForeignKey("Brand")]
		public int? BrandId { get; set; }
        public Category? Category { get; set; }
        public Brand? Brand { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
		public ICollection<NewsDetail> NewsDetails { get; set; } = new List<NewsDetail>();
		public ICollection<BannerDetail> BannerDetails { get; set; } = new List<BannerDetail>();
		public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
    }
}
