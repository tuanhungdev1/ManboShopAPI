using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.BrandDtos;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class BrandController : ControllerBase
	{
		private readonly IBrandService _brandService;

		public BrandController(IBrandService BrandService)
		{
			_brandService = BrandService;
		}


		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<BrandDto>>> GetAllBrand([FromQuery] BrandRequestParameters BrandRequestParameters)
		{
			var (Brand, metaData) = await _brandService.GetAllBrandAsync(BrandRequestParameters);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy dữ liệu danh sách các thương hiệu thành công.",
				Data = Brand,
				Pagination = metaData
			});
		}


		[HttpGet("{id:int}", Name = nameof(GetBrand))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<BrandDto>> GetBrand(int id)
		{
			var Brand = await _brandService.GetBrandByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu thương hiệu với Id {id} thành công.",
				Data = Brand
			});
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateBrand(
			[FromBody] BrandForCreateDto BrandDto)
		{
			await _brandService.CreateBrandAsync(BrandDto);

			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = $"Tạo mới một thương hiệu thành công.",
			});
		}


		[HttpPut("{id:int}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateBrand(
			int id,
			[FromBody] BrandForUpdateDto BrandDto)
		{
			await _brandService.UpdateBrandAsync(id, BrandDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật dữ liệu thương hiệu với Id {id} thành công.",
			});
		}


		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteBrand(int id)
		{
			await _brandService.DeleteBrandAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa thương hiệu với Id {id} thành công.",
			}); ;
		}


		[HttpGet("name/{name}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<BrandDto>> GetBrandByName(string name)
		{
			var Brand = await _brandService.GetBrandByNameAsync(name);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy dữ liệu thương hiệu với tên {name} thành công.",
				Data = Brand
			});
		}
	}

}
