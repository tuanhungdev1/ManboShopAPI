namespace ManboShopAPI.Domain.Exceptions.NotFound
{
	public class NewsNotFoundException : NotFoundException
	{
		public NewsNotFoundException(int newsId)
			: base($"Tin tức với Id {newsId} không tồn tại trong hệ thống.")
		{
		}

		public NewsNotFoundException(string message)
			: base(message)
		{
		}
	}
}
