using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class Address : BaseEntity
	{
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }
        [Required]
        [MaxLength(20)]
		public required string PhoneNumber { get; set; }
		[Required]
		[MaxLength(200)]
		public required string FlatOrHouse { get; set; }
		[Required]
		[MaxLength(200)]
		public required string BuildingOrCompanyOrApartment { get; set; }
		[Required]
		[MaxLength(200)]
		public required string AreaOrColonyOrStreetOrSectorOrVillage { get; set; }
		[Required]
		[MaxLength(200)]
		public required string City { get; set; }
		[Required]
		[MaxLength(100)]
		public required string PinCode { get; set; }
		[Required]
		[MaxLength(100)]
		public required string State { get; set; }
		public bool IsDefault { get; set; }
	}
}
