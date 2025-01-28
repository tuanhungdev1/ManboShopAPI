using System.ComponentModel.DataAnnotations;

public class CartItemForUpdateDto
{
	[Required]
	[Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
	public int Quantity { get; set; }
}