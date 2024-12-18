using ManboShopAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ManboShopAPI.Controllers
{
	[Route("api/products")]
	[ApiController]
	public class ProductController : ControllerBase
	{
       private readonly ILoggerService _logger;


        public ProductController(ILoggerService loggerService)
        {
            _logger = loggerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync()
        {
            return Ok(new
            {
                Message = "Lấy Dữ Liệu Thành Công"
            });
        }
    }
}
