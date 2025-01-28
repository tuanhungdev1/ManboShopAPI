namespace ManboShopAPI.Domain.Entities
{
	public class ProductImage : BaseEntity
	{
        public required string ImageUrl { get; set; }
        public required int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
