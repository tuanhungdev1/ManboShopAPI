using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class CategoryConfiguration : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			
			builder.HasData(GetPreconfiguredCategories());
		}

		private List<Category> GetPreconfiguredCategories()
		{
			return new List<Category>
			{
				new Category { Id = 1, Name = "Men's Clothing", ImageUrl = "https://example.com/images/men-clothing.jpg" },
				new Category { Id = 2, Name = "Women's Clothing", ImageUrl = "https://example.com/images/women-clothing.jpg" },
				new Category { Id = 3, Name = "Children's Clothing", ImageUrl = "https://example.com/images/children-clothing.jpg" },
				new Category { Id = 4, Name = "Shoes", ImageUrl = "https://example.com/images/shoes.jpg" },
				new Category { Id = 5, Name = "Bags", ImageUrl = "https://example.com/images/bags.jpg" },
				new Category { Id = 6, Name = "Accessories", ImageUrl = "https://example.com/images/accessories.jpg" },
				new Category { Id = 7, Name = "Watches", ImageUrl = "https://example.com/images/watches.jpg" },
				new Category { Id = 8, Name = "Sportswear", ImageUrl = "https://example.com/images/sportswear.jpg" },
				new Category { Id = 9, Name = "Swimwear", ImageUrl = "https://example.com/images/swimwear.jpg" },
				new Category { Id = 10, Name = "Formal Wear", ImageUrl = "https://example.com/images/formal-wear.jpg" },
				new Category { Id = 11, Name = "Casual Wear", ImageUrl = "https://example.com/images/casual-wear.jpg" },
				new Category { Id = 12, Name = "T-Shirts", ImageUrl = "https://example.com/images/t-shirts.jpg" },
				new Category { Id = 13, Name = "Jeans", ImageUrl = "https://example.com/images/jeans.jpg" },
				new Category { Id = 14, Name = "Jackets & Coats", ImageUrl = "https://example.com/images/jackets-coats.jpg" },
				new Category { Id = 15, Name = "Hats & Caps", ImageUrl = "https://example.com/images/hats-caps.jpg" },
				new Category { Id = 16, Name = "Scarves", ImageUrl = "https://example.com/images/scarves.jpg" },
				new Category { Id = 17, Name = "Sunglasses", ImageUrl = "https://example.com/images/sunglasses.jpg" },
				new Category { Id = 18, Name = "Belts", ImageUrl = "https://example.com/images/belts.jpg" },
				new Category { Id = 19, Name = "Undergarments", ImageUrl = "https://example.com/images/undergarments.jpg" },
				new Category { Id = 20, Name = "Sports Shoes", ImageUrl = "https://example.com/images/sports-shoes.jpg" },
				new Category { Id = 21, Name = "Boots", ImageUrl = "https://example.com/images/boots.jpg" },
				new Category { Id = 22, Name = "High Heels", ImageUrl = "https://example.com/images/high-heels.jpg" },
				new Category { Id = 23, Name = "Sneakers", ImageUrl = "https://example.com/images/sneakers.jpg" },
				new Category { Id = 24, Name = "Suits", ImageUrl = "https://example.com/images/suits.jpg" },
				new Category { Id = 25, Name = "Dresses", ImageUrl = "https://example.com/images/dresses.jpg" },
				new Category { Id = 26, Name = "Blouses", ImageUrl = "https://example.com/images/blouses.jpg" },
				new Category { Id = 27, Name = "Skirts", ImageUrl = "https://example.com/images/skirts.jpg" },
				new Category { Id = 28, Name = "Shorts", ImageUrl = "https://example.com/images/shorts.jpg" },
				new Category { Id = 29, Name = "Pajamas", ImageUrl = "https://example.com/images/pajamas.jpg" },
				new Category { Id = 30, Name = "Outerwear", ImageUrl = "https://example.com/images/outerwear.jpg" },
				new Category { Id = 31, Name = "Activewear", ImageUrl = "https://example.com/images/activewear.jpg" },
				new Category { Id = 32, Name = "Raincoats", ImageUrl = "https://example.com/images/raincoats.jpg" },
				new Category { Id = 33, Name = "Cardigans", ImageUrl = "https://example.com/images/cardigans.jpg" },
				new Category { Id = 34, Name = "Sweaters", ImageUrl = "https://example.com/images/sweaters.jpg" },
				new Category { Id = 35, Name = "Leggings", ImageUrl = "https://example.com/images/leggings.jpg" },
				new Category { Id = 36, Name = "Tracksuits", ImageUrl = "https://example.com/images/tracksuits.jpg" },
				new Category { Id = 37, Name = "Gloves", ImageUrl = "https://example.com/images/gloves.jpg" },
				new Category { Id = 38, Name = "Socks", ImageUrl = "https://example.com/images/socks.jpg" },
				new Category { Id = 39, Name = "Loungewear", ImageUrl = "https://example.com/images/loungewear.jpg" },
				new Category { Id = 40, Name = "Winter Wear", ImageUrl = "https://example.com/images/winter-wear.jpg" }
			};
		}
	}
}
