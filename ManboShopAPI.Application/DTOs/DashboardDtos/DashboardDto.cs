

using ManboShopAPI.Application.DTOs.OrderDtos;

namespace ManboShopAPI.Application.DTOs.DashboardDto
{
	public class DashboardDto
	{
        public decimal TotalSalesThisMonth { get; set; }
        public int TotalCustomersThisMonth { get; set; }
        public int TotalOrdersThisMonth { get; set; }
        public int MonthlyOrderGoal { get; set; }
        public int OrdersLeftToGoal { get; set; }

        public class BestSellingProductDto
        {
            public string ProductName { get; set; }
            public decimal TotalSales { get; set; }
            public int NumberOfSales { get; set; }
        }


        public List<BestSellingProductDto> BestSellingProducts { get; set; }

        public List<OrderDto> RecentOrders { get; set; }
    }
}
