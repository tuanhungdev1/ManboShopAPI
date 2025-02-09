

namespace ManboShopAPI.Application.Common.Helpers
{
	public static class FormatTime
	{
		public static DateTime GetVietnamTime()
		{
			TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
			return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, vietnamTimeZone);
		}
	}
}
