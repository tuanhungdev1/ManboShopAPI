namespace ManboShopAPI.Domain.Entities
{
	public class Cart : BaseEntity
	{
        public string? SessionId { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
