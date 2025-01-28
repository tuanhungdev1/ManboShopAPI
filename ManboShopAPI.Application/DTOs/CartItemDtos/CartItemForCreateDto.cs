using System.ComponentModel.DataAnnotations;

public class CartItemForCreateDto
{
	[Required]
	public int ProductId { get; set; }

	[Required]
	public int ProductVariantValueId { get; set; }

	[Required]
	[Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0")]
	public int Quantity { get; set; }
}