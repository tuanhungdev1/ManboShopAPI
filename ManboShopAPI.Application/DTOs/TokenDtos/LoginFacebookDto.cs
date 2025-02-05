using System.ComponentModel.DataAnnotations;

namespace ManboShopAPI.Application.DTOs.TokenDtos
{
	public class LoginFacebookDto
	{
		[Required(ErrorMessage = "Credential không được để trống.")]
		public string Credential { get; set; }
	}
}
