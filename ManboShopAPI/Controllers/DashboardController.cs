using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.DashboardDto;
using Microsoft.AspNetCore.Mvc;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/dashboard")]
	public class DashboardController : ControllerBase
	{
		private readonly IDashboardService _dashboardService;

		public DashboardController(IDashboardService dashboardService)
		{
			_dashboardService = dashboardService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public async Task<ActionResult<DashboardDto>> GetDashboardData()
		{
			var dashboardData = await _dashboardService.GetDashboardDataAsync();
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Data = dashboardData,
				Message = "Lấy dữ liệu dashboard thành công."
			});
		}
	}
}
