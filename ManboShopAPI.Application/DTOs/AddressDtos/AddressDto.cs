namespace ManboShopAPI.Application.DTOs.AddressDtos
{
	public class AddressDto
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string AddressLine { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Country { get; set; }
		public string PostalCode { get; set; }
		public bool IsDefault { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
