using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Domain.Entities
{
	public class BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public DateTime CreatedAt { get; set; } = GetVietnamTime();
		public DateTime? UpdatedAt { get; set; }

		static DateTime GetVietnamTime()
		{
			TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
			return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
		}
	}
}
