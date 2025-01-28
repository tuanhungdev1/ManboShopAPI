using System.ComponentModel.DataAnnotations;
using ManboShopAPI.Application.DTOs.CartDtos;

namespace ManboShopAPI.Application.Common.Validation
{
	public class CartConstraintAttribute : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var cart = (CartForCreateDto)validationContext.ObjectInstance;

			if(cart.UserId == null && cart.SessionId == null)
			{
				return new ValidationResult("Phải có SessionId hoặc UserId, nhưng không được có cả hai.");
			}

			if(cart.UserId != null && cart.SessionId != null)
			{
				return new ValidationResult("Chỉ được chọn một trong hai UserId hoặc SessionId.");
			}

			return ValidationResult.Success;
		}
	}
}
