using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Domain.Enums;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Security.Claims;
using System.Text.Json;

[ApiController]
[Authorize]
[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class OrderController : ControllerBase
{
	private readonly IOrderService _orderService;

	public OrderController(IOrderService orderService)
	{
		_orderService = orderService;
	}

	[HttpGet]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetAllOrders([FromQuery] OrderRequestParameters parameters)
	{
		var (orders, metadata) = await _orderService.GetAllOrdersAsync(parameters);
		Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Lấy danh sách đơn hàng thành công.",
			Data = orders
		});
	}

	[HttpGet("{orderId:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<OrderDto>> GetOrderById(int orderId)
	{
		var order = await _orderService.GetOrderByIdAsync(orderId);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Lấy thông tin đơn hàng {orderId} thành công.",
			Data = order
		});
	}

	[HttpGet("user")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrdersByUserId([FromQuery] OrderForUserRequestParameters orderForUserRequestParameters)
	{
		var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
		var orders = await _orderService.GetOrdersByUserIdAsync(userId, orderForUserRequestParameters);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Lấy danh sách đơn hàng của người dùng {userId} thành công.",
			Data = orders
		});
	}

	[HttpGet("recent/{count:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetRecentOrders(int count)
	{
		var orders = await _orderService.GetRecentOrdersAsync(count);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Lấy danh sách đơn hàng gần đây thành công.",
			Data = orders
		});
	}

	[HttpGet("statistics/status")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<Dictionary<OrderStatus, int>>> GetOrderStatusStatistics()
	{
		var statistics = await _orderService.GetOrderStatusStatisticsAsync();
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Lấy thống kê trạng thái đơn hàng thành công.",
			Data = statistics
		});
	}

	[HttpGet("revenue/total")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<decimal>> GetTotalRevenue()
	{
		var revenue = await _orderService.GetTotalRevenueAsync();
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Lấy tổng doanh thu thành công.",
			Data = revenue
		});
	}

	[HttpGet("revenue/daily")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<decimal>> GetDailyRevenue([FromQuery] DateTime date)
	{
		var revenue = await _orderService.GetDailyRevenueAsync(date);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Lấy doanh thu ngày {date:dd/MM/yyyy} thành công.",
			Data = revenue
		});
	}

	[HttpGet("date-range")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrdersByDateRange(
		[FromQuery] DateTime startDate,
		[FromQuery] DateTime endDate)
	{
		var orders = await _orderService.GetOrdersByDateRangeAsync(startDate, endDate);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = "Lấy danh sách đơn hàng theo khoảng thời gian thành công.",
			Data = orders
		});
	}

	[HttpPost]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status201Created)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	public async Task<ActionResult<OrderDto>> CreateOrder([FromBody] OrderForCreateDto orderDto)
	{
		var order = await _orderService.CreateOrderAsync(orderDto);
		return StatusCode(201, new ApiResponse<object>
		{
			StatusCode = 201,
			Success = true,
			Message = "Tạo đơn hàng thành công.",
			Data = order
		});
	}

	[HttpPut("{orderId:int}")]
	[ValidationFilter]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<OrderDto>> UpdateOrder(int orderId, [FromBody] OrderForUpdateDto orderDto)
	{
		var order = await _orderService.UpdateOrderAsync(orderId, orderDto);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Cập nhật đơn hàng {orderId} thành công.",
			Data = order
		});
	}

	[HttpPut("{orderId:int}/status")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<OrderDto>> UpdateOrderStatus(int orderId, [FromBody] OrderStatus status)
	{
		var order = await _orderService.UpdateOrderStatusAsync(orderId, status);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Cập nhật trạng thái đơn hàng {orderId} thành công.",
			Data = order
		});
	}

	[HttpPut("{orderId:int}/cancel")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<ActionResult<OrderDto>> CancelOrder(int orderId, [FromBody] string? cancellationReason)
	{
		var order = await _orderService.CancelOrderAsync(orderId, cancellationReason);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Hủy đơn hàng {orderId} thành công.",
			Data = order
		});
	}

	[HttpDelete("{orderId:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	public async Task<IActionResult> DeleteOrder(int orderId)
	{
		await _orderService.DeleteOrderAsync(orderId);
		return Ok(new ApiResponse<object>
		{
			StatusCode = 200,
			Success = true,
			Message = $"Xóa đơn hàng {orderId} thành công."
		});
	}
}