using ManboShopAPI.Application.DTOs.DashboardDto;

namespace ManboShopAPI.Application.Contracts
{
	public interface IDashboardService
	{
		Task<DashboardDto> GetDashboardDataAsync();
	}
}
