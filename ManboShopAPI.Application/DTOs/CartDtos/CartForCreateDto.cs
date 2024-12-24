using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.DTOs.CartDtos
{
	public class CartForCreateDto
	{
		[Required(ErrorMessage = "")]
		public string SessionId { get; set; }
		public int? UserId { get; set; }
	}
}
