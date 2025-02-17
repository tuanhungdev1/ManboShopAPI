

using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.UserDtos
{
	public class UserUpdateAvatarDto
	{
		[Required(ErrorMessage = "Vui lòng chọn file ảnh.")]
        public IFormFile File { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
