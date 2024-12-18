using Bogus;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			// Cấu hình quan hệ như bạn đã định nghĩa
			builder.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId)
				.OnDelete(DeleteBehavior.SetNull)
				.IsRequired(false);

			builder.HasOne(p => p.Brand)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.BrandId)
				.OnDelete(DeleteBehavior.SetNull)
				.IsRequired(false);

		
			var faker = new Faker<Product>("en")
				.RuleFor(p => p.Id, f => f.IndexFaker + 1)
				.RuleFor(p => p.Name, f => GenerateProductName(f))
				.RuleFor(p => p.Description, f => GenerateProductDescription(f))
				.RuleFor(p => p.Specification, f => GenerateSpecification(f))
				.RuleFor(p => p.Price, f => f.Random.Decimal(50000, 5000000)) // Khoảng 50k-5tr VND
				.RuleFor(p => p.OldPrice, (f, p) => p.Price * f.Random.Decimal(1.1m, 1.5m)) // Giá cũ cao hơn 10-50%
				.RuleFor(p => p.Quantity, f => f.Random.Int(10, 500))
				.RuleFor(p => p.BuyTurn, f => f.Random.Int(0, 200))
				.RuleFor(p => p.CategoryId, f => f.Random.Int(1, 5)) // Giả sử có 5 category
				.RuleFor(p => p.BrandId, f => f.Random.Int(1, 10)); // Giả sử có 10 brands

			// Tạo 40 sản phẩm
			var products = faker.Generate(200);
			builder.HasData(products);
		}

		private string GenerateProductName(Faker faker)
		{
			string[] productTypes = new[] {
				"Áo Sơ Mi", "Quần Jean", "Váy Liền", "Áo Khoác",
				"Áo Thun", "Quần Tây", "Đầm Dạ Hội", "Áo Polo",
				"Quần Short", "Blazer", "Áo Len", "Quần Jogger"
			};

			string[] styles = new[] {
				"Sang Trọng", "Năng Động", "Trẻ Trung", "Cổ Điển",
				"Hiện Đại", "Thời Thượng", "Thoải Mái"
			};

			string[] brands = new[] {
				"Nike", "Adidas", "Zara", "H&M", "Uniqlo",
				"Gucci", "Louis Vuitton", "Chanel"
			};

			return $"{faker.Random.ArrayElement(brands)} {faker.Random.ArrayElement(productTypes)} {faker.Random.ArrayElement(styles)}";
		}

		private string GenerateProductDescription(Faker faker)
		{
			string[] materials = new[] {
				"Cotton cao cấp", "Vải Linen", "Chất liệu Nhật Bản",
				"Vải Organic", "Sợi Bamboo", "Vải Châu Âu"
			};

			string[] features = new[] {
				"Thoáng mát", "Co giãn tốt", "Kiểu dáng thanh lịch",
				"Thiết kế hiện đại", "Phù hợp nhiều dáng người"
			};

			return $"Sản phẩm được làm từ {faker.Random.ArrayElement(materials)}. " +
				   $"{faker.Random.ArrayElement(features)}. " +
				   $"Phù hợp cho các dịp {faker.Random.ArrayElement(new[] { "văn phòng", "dạo phố", "tiệc tùng", "thể thao" })}";
		}

		private string GenerateSpecification(Faker faker)
		{
			string[] sizes = new[] { "XS", "S", "M", "L", "XL", "XXL" };
			string[] colors = new[] { "Đen", "Trắng", "Xám", "Xanh Navy", "Đỏ", "Hồng" };

			return $"Kích thước: {string.Join(", ", faker.Random.ArrayElements(sizes, 3))}. " +
				   $"Màu sắc: {string.Join(", ", faker.Random.ArrayElements(colors, 2))}";
		}
	}
}