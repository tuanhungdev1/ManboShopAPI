using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.TokenDtos
{
	public class LoginGoogleDto
	{
		[Required(ErrorMessage = "Credential không được để trống.")]
        public string Credential { get; set; }
    }
}
