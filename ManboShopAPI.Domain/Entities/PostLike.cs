namespace ManboShopAPI.Domain.Entities
{
	public class PostLike : BaseEntity
	{
		public int PostId { get; set; }
		public Post Post { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
	}
}
