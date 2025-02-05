namespace ManboShopAPI.Application.Common.Models
{
	public class GoogleUserInfo
	{
		public string Sub { get; set; }  // ID duy nhất của người dùng trong Google
		public string Name { get; set; }  // Họ và tên đầy đủ của người dùng
		public string Given_Name { get; set; }  // Tên riêng (first name)
		public string Family_Name { get; set; }  // Họ (last name)
		public string Picture { get; set; }  // URL ảnh đại diện của người dùng
		public string Email { get; set; }  // Địa chỉ email của người dùng
		public bool EmailVerified { get; set; }  // Trạng thái xác minh email
	}
}
