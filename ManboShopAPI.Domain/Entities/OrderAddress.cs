using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class OrderAddress : BaseEntity
	{
		public int OrderId { get; set; }
		public Order Order { get; set; }
		[Required]
		[MaxLength(100)]
		public required string Name { get; set; }
		[Required]
		[MaxLength(20)]
		public required string PhoneNumber { get; set; }
		[Required]
		[MaxLength(1000)]
		public required string AddressLine { get; set; }
		[Required]
		[MaxLength(200)]
		public required string City { get; set; }
		[Required]
		[MaxLength(200)]
		public required string State { get; set; }
		[Required]
		[MaxLength(200)]
		public required string Country { get; set; }
		[Required]
		[MaxLength(100)]
		public required string PostalCode { get; set; }
	}
}
