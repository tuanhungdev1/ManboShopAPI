namespace ManboShopAPI.Application.DTOs.AddressDtos
{
	using System.ComponentModel.DataAnnotations;

	public class AddressForCreateDto
	{
		[Required(ErrorMessage = "Họ và tên không được để trống.")]
		[MaxLength(100, ErrorMessage = "Họ và tên không được vượt quá 100 ký tự.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Số điện thoại không được để trống.")]
		[MaxLength(20, ErrorMessage = "Số điện thoại không được vượt quá 20 ký tự.")]
		[Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "Địa chỉ chi tiết không được để trống.")]
		[MaxLength(1000, ErrorMessage = "Địa chỉ chi tiết không được vượt quá 1000 ký tự.")]
		public string AddressLine { get; set; }

		[Required(ErrorMessage = "Thành phố không được để trống.")]
		[MaxLength(200, ErrorMessage = "Thành phố không được vượt quá 200 ký tự.")]
		public string City { get; set; }

		[Required(ErrorMessage = "Tỉnh/Bang không được để trống.")]
		[MaxLength(200, ErrorMessage = "Tỉnh/Bang không được vượt quá 200 ký tự.")]
		public string State { get; set; }

		[Required(ErrorMessage = "Quốc gia không được để trống.")]
		[MaxLength(200, ErrorMessage = "Quốc gia không được vượt quá 200 ký tự.")]
		public string Country { get; set; }

		[Required(ErrorMessage = "Mã bưu điện không được để trống.")]
		[MaxLength(100, ErrorMessage = "Mã bưu điện không được vượt quá 100 ký tự.")]
		public string PostalCode { get; set; }
		public bool IsDefault { get; set; }
	}

}
