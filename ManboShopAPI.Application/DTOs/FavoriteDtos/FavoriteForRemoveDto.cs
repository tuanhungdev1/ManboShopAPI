using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.FavoriteDtos
{
	public class FavoriteForRemoveDto
	{
		[Required(ErrorMessage = "Id người dùng là bắt buộc")]
		public int UserId { get; set; }
		[Required(ErrorMessage = "Id sản phẩm là bắt buộc")]
		public int ProductId { get; set; }
	}
}
