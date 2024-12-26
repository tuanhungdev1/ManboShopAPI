using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Feedback : BaseEntity
	{
		[Required]
		[MaxLength(1000)]
        public string Content { get; set; }
		[Range(0, 5)]
		[Required]
        public int Star { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
