using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class BrandConfiguration : IEntityTypeConfiguration<Brand>
	{
		public void Configure(EntityTypeBuilder<Brand> builder)
		{
			
		}

		private List<Brand> GetPreconfiguredBrands()
		{
			return new List<Brand>
			{
				new Brand { Id = 1, Name = "Nike", ImageUrl = "https://example.com/images/nike.jpg" },
				new Brand { Id = 2, Name = "Adidas", ImageUrl = "https://example.com/images/adidas.jpg" },
				new Brand { Id = 3, Name = "Gucci", ImageUrl = "https://example.com/images/gucci.jpg" },
				new Brand { Id = 4, Name = "Louis Vuitton", ImageUrl = "https://example.com/images/louis-vuitton.jpg" },
				new Brand { Id = 5, Name = "Zara", ImageUrl = "https://example.com/images/zara.jpg" },
				new Brand { Id = 6, Name = "H&M", ImageUrl = "https://example.com/images/h&m.jpg" },
				new Brand { Id = 7, Name = "Chanel", ImageUrl = "https://example.com/images/chanel.jpg" },
				new Brand { Id = 8, Name = "Prada", ImageUrl = "https://example.com/images/prada.jpg" },
				new Brand { Id = 9, Name = "Versace", ImageUrl = "https://example.com/images/versace.jpg" },
				new Brand { Id = 10, Name = "Burberry", ImageUrl = "https://example.com/images/burberry.jpg" },
				new Brand { Id = 11, Name = "Dior", ImageUrl = "https://example.com/images/dior.jpg" },
				new Brand { Id = 12, Name = "Calvin Klein", ImageUrl = "https://example.com/images/calvin-klein.jpg" },
				new Brand { Id = 13, Name = "Tommy Hilfiger", ImageUrl = "https://example.com/images/tommy-hilfiger.jpg" },
				new Brand { Id = 14, Name = "Levi's", ImageUrl = "https://example.com/images/levis.jpg" },
				new Brand { Id = 15, Name = "Uniqlo", ImageUrl = "https://example.com/images/uniqlo.jpg" },
				new Brand { Id = 16, Name = "Lacoste", ImageUrl = "https://example.com/images/lacoste.jpg" },
				new Brand { Id = 17, Name = "The North Face", ImageUrl = "https://example.com/images/the-north-face.jpg" },
				new Brand { Id = 18, Name = "Ralph Lauren", ImageUrl = "https://example.com/images/ralph-lauren.jpg" },
				new Brand { Id = 19, Name = "Puma", ImageUrl = "https://example.com/images/puma.jpg" },
				new Brand { Id = 20, Name = "Hugo Boss", ImageUrl = "https://example.com/images/hugo-boss.jpg" },
				new Brand { Id = 21, Name = "Armani", ImageUrl = "https://example.com/images/armani.jpg" },
				new Brand { Id = 22, Name = "Balenciaga", ImageUrl = "https://example.com/images/balenciaga.jpg" },
				new Brand { Id = 23, Name = "Fendi", ImageUrl = "https://example.com/images/fendi.jpg" },
				new Brand { Id = 24, Name = "Givenchy", ImageUrl = "https://example.com/images/givenchy.jpg" },
				new Brand { Id = 25, Name = "Hermès", ImageUrl = "https://example.com/images/hermes.jpg" },
				new Brand { Id = 26, Name = "Salvatore Ferragamo", ImageUrl = "https://example.com/images/salvatore-ferragamo.jpg" },
				new Brand { Id = 27, Name = "Valentino", ImageUrl = "https://example.com/images/valentino.jpg" },
				new Brand { Id = 28, Name = "Dolce & Gabbana", ImageUrl = "https://example.com/images/dolce-gabbana.jpg" },
				new Brand { Id = 29, Name = "Gap", ImageUrl = "https://example.com/images/gap.jpg" },
				new Brand { Id = 30, Name = "Forever 21", ImageUrl = "https://example.com/images/forever21.jpg" },
				new Brand { Id = 31, Name = "New Balance", ImageUrl = "https://example.com/images/new-balance.jpg" },
				new Brand { Id = 32, Name = "Vans", ImageUrl = "https://example.com/images/vans.jpg" },
				new Brand { Id = 33, Name = "Converse", ImageUrl = "https://example.com/images/converse.jpg" },
				new Brand { Id = 34, Name = "Under Armour", ImageUrl = "https://example.com/images/under-armour.jpg" },
				new Brand { Id = 35, Name = "Reebok", ImageUrl = "https://example.com/images/reebok.jpg" },
				new Brand { Id = 36, Name = "Coach", ImageUrl = "https://example.com/images/coach.jpg" },
				new Brand { Id = 37, Name = "Kate Spade", ImageUrl = "https://example.com/images/kate-spade.jpg" },
				new Brand { Id = 38, Name = "Michael Kors", ImageUrl = "https://example.com/images/michael-kors.jpg" },
				new Brand { Id = 39, Name = "Bally", ImageUrl = "https://example.com/images/bally.jpg" },
				new Brand { Id = 40, Name = "Guess", ImageUrl = "https://example.com/images/guess.jpg" }
			};
		}
	}
}
