using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.FavoriteDtos
{
	public class FavoriteForCreateDto
	{
		[Required(ErrorMessage = "Id sản phẩm là bắt buộc")]
		public int ProductId { get; set; }
    }
}
