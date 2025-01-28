namespace ManboShopAPI.Domain.Entities
{
	public class Favorite : BaseEntity
	{
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
