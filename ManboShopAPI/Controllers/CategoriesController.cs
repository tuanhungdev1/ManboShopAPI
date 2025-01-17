using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Domain.Interfaces;
using ManboShopAPI.Filters;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	
		[ApiController]
		[Route("api/[controller]")]
		[Produces(MediaTypeNames.Application.Json)]
		public class CategoriesController : ControllerBase
		{
			private readonly ICategoryService _categoryService;

			public CategoriesController(ICategoryService categoryService)
			{
				_categoryService = categoryService;
			}

			
			[HttpGet]
			[ProducesResponseType(StatusCodes.Status200OK)]
			[ProducesResponseType(StatusCodes.Status500InternalServerError)]
			public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories([FromQuery] CategoryRequestParameters categoryRequestParameters)
			{
				var (categories, metaData) = await _categoryService.GetAllCategoriesAsync(categoryRequestParameters);
				return Ok(new ApiResponse<object>
				{
					StatusCode = 200,
					Success = true,
					Message = "Lấy dữ liệu danh sách các danh mục thành công.",
					Data = categories,
					Pagination = metaData
				});
			}

			
			[HttpGet("{id:int}", Name = nameof(GetCategory))]
			[ProducesResponseType(StatusCodes.Status200OK)]
			[ProducesResponseType(StatusCodes.Status404NotFound)]
			public async Task<ActionResult<CategoryDto>> GetCategory(int id)
			{
				var category = await _categoryService.GetCategoryByIdAsync(id);
				return Ok(new ApiResponse<object>
				{
					StatusCode = 200,
					Success = true,
					Message = $"Lấy dữ liệu danh mục với Id {id} thành công.",
					Data = category
				});
		}

			[HttpPost]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
			[ProducesResponseType(StatusCodes.Status400BadRequest)]
			public async Task<IActionResult> CreateCategory(
				[FromBody] CategoryForCreateDto categoryDto)
			{
				await _categoryService.CreateCategoryAsync(categoryDto);

				return StatusCode(201,new ApiResponse<object>
				{
					StatusCode = 201,
					Success = true,
					Message = $"Tạo mới một danh mục thành công.",
				});
			}

			
			[HttpPut("{id:int}")]
			[ValidationFilter]
			[ProducesResponseType(StatusCodes.Status204NoContent)]
			[ProducesResponseType(StatusCodes.Status400BadRequest)]
			[ProducesResponseType(StatusCodes.Status404NotFound)]
			public async Task<IActionResult> UpdateCategory(
				int id,
				[FromBody] CategoryForUpdateDto categoryDto)
			{
				await _categoryService.UpdateCategoryAsync(id, categoryDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật dữ liệu danh mục với Id {id} thành công.",
			});
		}

			
			[HttpDelete("{id:int}")]
			[ProducesResponseType(StatusCodes.Status204NoContent)]
			[ProducesResponseType(StatusCodes.Status404NotFound)]
			public async Task<IActionResult> DeleteCategory(int id)
			{
				await _categoryService.DeleteCategoryAsync(id);
				return Ok(new ApiResponse<object>
				{
					StatusCode = 200,
					Success = true,
					Message = $"Xóa danh mục với Id {id} thành công.",
				}); ;
			}

			
			[HttpGet("name/{name}")]
			[ProducesResponseType(StatusCodes.Status200OK)]
			[ProducesResponseType(StatusCodes.Status404NotFound)]
			public async Task<ActionResult<CategoryDto>> GetCategoryByName(string name)
			{
				var category = await _categoryService.GetCategoryByNameAsync(name);
				return Ok(new ApiResponse<object>
				{
					StatusCode = 200,
					Success = true,
					Message = $"Lấy dữ liệu danh mục với tên {name} thành công.",
					Data = category
				});
		}

		[HttpPost("subcategories")]
		[ValidationFilter]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateSubCategories([FromBody] SubCategoriesForCreateDto subCategoriesForCreateDto)
		{
			await _categoryService.CreateChildCategoriesAsync(subCategoriesForCreateDto.ParentCategoryId, subCategoriesForCreateDto.ChildCategoryNames);

			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo danh sách các category con thành công."
			});
		}
	}
	
}
