using ManboShopAPI.Application.Common.Response;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ManboShopAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	[Produces(MediaTypeNames.Application.Json)]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
		{
			var products = await _productService.GetAllProductsAsync();
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = "Lấy danh sách sản phẩm thành công.",
				Data = products
			});
		}

		[HttpGet("{id:int}", Name = nameof(GetProduct))]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<ProductDto>> GetProduct(int id)
		{
			var product = await _productService.GetProductByIdAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy thông tin sản phẩm với Id {id} thành công.",
				Data = product
			});
		}

		[HttpGet("category/{categoryId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductsByCategory(int categoryId)
		{
			var products = await _productService.GetProductsByCategoryAsync(categoryId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách sản phẩm theo danh mục Id {categoryId} thành công.",
				Data = products
			});
		}

		[HttpGet("brand/{brandId:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductsByBrand(int brandId)
		{
			var products = await _productService.GetProductsByBrandAsync(brandId);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Lấy danh sách sản phẩm theo thương hiệu Id {brandId} thành công.",
				Data = products
			});
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> CreateProduct([FromBody] ProductForCreateDto productDto)
		{
			var createdProduct = await _productService.CreateProductAsync(productDto);
			return StatusCode(201, new ApiResponse<object>
			{
				StatusCode = 201,
				Success = true,
				Message = "Tạo mới sản phẩm thành công.",
				Data = createdProduct
			});
		}

		[HttpPut("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateProduct(
			int id,
			[FromBody] ProductForUpdateDto productDto)
		{
			var updatedProduct = await _productService.UpdateProductAsync(id, productDto);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật sản phẩm với Id {id} thành công.",
				Data = updatedProduct
			});
		}

		[HttpDelete("{id:int}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			await _productService.DeleteProductAsync(id);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Xóa sản phẩm với Id {id} thành công."
			});
		}

		[HttpPut("{id:int}/quantity")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		[ProducesResponseType(StatusCodes.Status404NotFound)]
		public async Task<IActionResult> UpdateProductQuantity(
			int id,
			[FromBody] int quantity)
		{
			await _productService.UpdateProductQuantityAsync(id, quantity);
			return Ok(new ApiResponse<object>
			{
				StatusCode = 200,
				Success = true,
				Message = $"Cập nhật số lượng sản phẩm với Id {id} thành công.",
				Data = new { Id = id, Quantity = quantity }
			});
		}
	}
}
