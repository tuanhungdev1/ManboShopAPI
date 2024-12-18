using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Domain.Entities
{
	public class User: IdentityUser<int>
	{
        [MaxLength(100)]
        public string? FirstName { get; set; }
        [MaxLength(100)]
        public string? LastName { get; set; }
		[MaxLength(300)]
		public string? Address { get; set; }
        public string? ProfilePictureUrl { get; set; }
		public string? RefreshToken { get; set; }
		public DateTime? RefreshTokenExpiryTime { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime? UpdatedAt { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
		public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
