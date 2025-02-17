namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserDto
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Address { get; set; }
		public string? ProfilePictureUrl { get; set; }
		public string? PhoneNumber { get; set; }
        public int TotalFavoriteProducts { get; set; }
        public int TotalCartProducts { get; set; }
		public bool IsLocked { get; set; }
		public DateTime? LockoutEnd { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public ICollection<string> Roles { get; set; } = new List<string>();
    }
}
