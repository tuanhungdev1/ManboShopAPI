using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.BannerDetailDtos
{
	public class BannerDetailForCreateDto
	{
        [Required(ErrorMessage = "Id banner không được để trống")]
        public int BannerId { get; set; }
        [Required(ErrorMessage = "Id sản phẩm không được để trống")]
        public int ProductId { get; set; }
    }
}
