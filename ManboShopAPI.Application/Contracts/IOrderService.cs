using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface IOrderService
	{
		Task<(IEnumerable<OrderDto> orders, MetaData metaData)> GetAllOrdersAsync(OrderRequestParameters orderRequestParameters);
		Task<OrderDto> GetOrderByIdAsync(int orderId);
		Task CreateOrderAsync(OrderForCreateDto orderForCreateDto);
		Task UpdateOrderAsync(int orderId, OrderForUpdateDto orderForUpdateDto);
		Task DeleteOrderAsync(int orderId);
		Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId);
	}
}
