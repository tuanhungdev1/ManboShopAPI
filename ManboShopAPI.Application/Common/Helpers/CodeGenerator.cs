namespace ManboShopAPI.Application.Common.Helpers
{
	public static class CodeGenerator
	{
		private static readonly Random _random = new Random();

		public static string GenerateCode()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars, 6)
				.Select(s => s[_random.Next(s.Length)]).ToArray());
		}
	}
}
