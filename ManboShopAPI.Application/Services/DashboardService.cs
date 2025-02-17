

using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.DashboardDto;
using ManboShopAPI.Application.DTOs.OrderDtos;
using ManboShopAPI.Application.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class DashboardService : IDashboardService
	{
		private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DashboardService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DashboardDto> GetDashboardDataAsync()
        {

            var now = DateTime.UtcNow;
            var firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            var totalSales = await _unitOfWork.OrderRepository
                .FindByCondition(o => 
                 o.CreatedAt >= firstDayOfMonth && o.CreatedAt <= lastDayOfMonth && o.PaymentStatus == Domain.Enums.PaymentStatus.Paid)
                .SumAsync(o => o.Total);
            
            var newCustomers = await _unitOfWork.UserRepository
                .FindByCondition(u => u.CreatedAt >= firstDayOfMonth && u.CreatedAt <= lastDayOfMonth)
				.CountAsync();

            var totalOrders = await _unitOfWork.OrderRepository
				.FindByCondition(o => o.CreatedAt >= firstDayOfMonth && o.CreatedAt <= lastDayOfMonth)
				.CountAsync();

            var bestSelling = await _unitOfWork.OrderRepository
                .FindByCondition(o => o.CreatedAt >= firstDayOfMonth && o.CreatedAt <= lastDayOfMonth)
                .SelectMany(o => o.OrderDetails)
                .GroupBy(od => od.ProductVariantValue.Product.Name)
                .Select(g => new DashboardDto.BestSellingProductDto
                {
                    ProductName = g.Key,
                    TotalSales = g.Sum(od => od.Price * od.Quantity),
                    NumberOfSales = g.Sum(od => od.Quantity)
                })
                .OrderByDescending(g => g.TotalSales)
                .Take(3)
                .ToListAsync();

            var recentOrders = await _unitOfWork.OrderRepository
                .FindAll()
                .OrderByDescending(o => o.CreatedAt)
                .Take(5)
                .ToListAsync();

            const int MONTHLY_ORDER_GOAL = 10000000;

            return new DashboardDto
            {
                TotalSalesThisMonth = totalSales,
                TotalCustomersThisMonth = newCustomers,
                TotalOrdersThisMonth = totalOrders,
                MonthlyOrderGoal = MONTHLY_ORDER_GOAL,
                OrdersLeftToGoal = Math.Max(0, MONTHLY_ORDER_GOAL - totalOrders),
                BestSellingProducts = bestSelling,
                RecentOrders = _mapper.Map<List<OrderDto>>(recentOrders)
            };
        }
    }
}
