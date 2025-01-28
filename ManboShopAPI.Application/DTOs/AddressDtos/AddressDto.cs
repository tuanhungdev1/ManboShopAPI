namespace ManboShopAPI.Application.DTOs.AddressDtos
{
	public class AddressDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FlatOrHouse { get; set; }
        public string BuildingOrCompanyOrApartment { get; set; }
        public string AreaOrColonyOrStreetOrSectorOrVillage { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string State { get; set; }
        public bool IsDefault { get; set; }
    }
}
