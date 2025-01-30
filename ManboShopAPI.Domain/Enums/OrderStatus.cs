namespace ManboShopAPI.Domain.Enums
{
	public enum OrderStatus
	{
		Pending = 1,      // Đơn hàng đang chờ xử lý
		Confirmed = 2,    // Đơn hàng đã được xác nhận
		Processing = 3,   // Đơn hàng đang được xử lý
		Shipped = 4,      // Đơn hàng đã được vận chuyển
		Delivered = 5,    // Đơn hàng đã giao thành công
		Cancelled = 6,    // Đơn hàng bị hủy
		Refunded = 7,     // Đơn hàng được hoàn tiền
		Failed = 8        // Đơn hàng thất bại
	}
}
