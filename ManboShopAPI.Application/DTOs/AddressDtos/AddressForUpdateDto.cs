using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.AddressDtos
{
	public class AddressForUpdateDto
	{
		[Required(ErrorMessage = "AddressId is required.")]
		public int AddressId { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "PhoneNumber is required.")]
		[MaxLength(20, ErrorMessage = "PhoneNumber cannot exceed 20 characters.")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "FlatOrHouse is required.")]
		[MaxLength(200, ErrorMessage = "FlatOrHouse cannot exceed 200 characters.")]
		public string FlatOrHouse { get; set; }

		[Required(ErrorMessage = "BuildingOrCompanyOrApartment is required.")]
		[MaxLength(200, ErrorMessage = "BuildingOrCompanyOrApartment cannot exceed 200 characters.")]
		public string BuildingOrCompanyOrApartment { get; set; }

		[Required(ErrorMessage = "AreaOrColonyOrStreetOrSectorOrVillage is required.")]
		[MaxLength(200, ErrorMessage = "AreaOrColonyOrStreetOrSectorOrVillage cannot exceed 200 characters.")]
		public string AreaOrColonyOrStreetOrSectorOrVillage { get; set; }

		[Required(ErrorMessage = "City is required.")]
		[MaxLength(200, ErrorMessage = "City cannot exceed 200 characters.")]
		public string City { get; set; }

		[Required(ErrorMessage = "PinCode is required.")]
		[MaxLength(100, ErrorMessage = "PinCode cannot exceed 100 characters.")]
		public string PinCode { get; set; }

		[Required(ErrorMessage = "State is required.")]
		[MaxLength(100, ErrorMessage = "State cannot exceed 100 characters.")]
		public string State { get; set; }

		public bool IsDefault { get; set; }
	}
}
