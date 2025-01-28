namespace ManboShopAPI.Application.DTOs.NewsDtos
{
	public class NewsDto
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public string Content { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		//public List<NewsDetailDto> NewsDetails { get; set; } = new();
	}
}
