using AutoMapper;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public CategoryService(ICategoryRepository categoryRepository,
								IMapper mapper,
								ILoggerService loggerService
								)
		{
			_categoryRepository = categoryRepository;
			_mapper = mapper;
			_logger = loggerService;
		}

		public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
		{
			var categories = await _categoryRepository.GetAllAsync(true);
			_logger.LogInfo("Lấy danh sách danh mục thành công.");
			return _mapper.Map<IEnumerable<CategoryDto>>(categories);
		}

		public async Task<CategoryDto> GetCategoryByIdAsync(int categoryId)
		{
			var category = await _categoryRepository.GetByIdAsync(categoryId);
			if(category == null)
			{
				_logger.LogError($"Không tìm thấy danh mục với id {categoryId}");
				throw new CategoryNotFoundException(categoryId);
			}
			_logger.LogInfo($"Lấy dữ liệu danh mục thành công.");
			return _mapper.Map<CategoryDto>(category);
		}

		public async Task CreateCategoryAsync(CategoryForCreateDto categoryForCreateDto)
		{
			var category = _mapper.Map<Category>(categoryForCreateDto);
			await _categoryRepository.AddAsync(category);
			await _categoryRepository.SaveChangesAsync();
			_logger.LogInfo("Tạo danh mục mới thành công.");
		}

		public async Task UpdateCategoryAsync(int categoryId, CategoryForUpdateDto categoryForUpdateDto)
		{
			
			var existingCategory = await _categoryRepository.GetByIdAsync(categoryId);
			if (existingCategory == null)
			{
				_logger.LogError($"Không tìm thấy danh mục với Id {categoryId}");
				throw new CategoryNotFoundException(categoryId);
			}

			if (existingCategory.Name == categoryForUpdateDto.Name ||
				await CategoryExistsAsync(categoryForUpdateDto.Name))
			{
				_logger.LogError($"Tên danh mục {categoryForUpdateDto.Name} đã tồn tại trong hệ thống.");
				throw new CategoryBadRequestException($"Tên danh mục {categoryForUpdateDto.Name} đã tồn tại trong hệ thống.");
			}

			_mapper.Map(categoryForUpdateDto, existingCategory);
			existingCategory.UpdatedAt = DateTime.UtcNow;
			_categoryRepository.Update(existingCategory);
			await _categoryRepository.SaveChangesAsync();
			_logger.LogInfo($"Cập nhật thành công danh mục với Id {existingCategory.Id}");
		}

		public async Task DeleteCategoryAsync(int categoryId)
		{
			var existingCategory = await _categoryRepository.GetByIdAsync(categoryId);
			if (existingCategory == null)
			{
				_logger.LogError($"Không tìm thấy danh mục với Id {categoryId}");
				throw new CategoryNotFoundException(categoryId);
			}

			_categoryRepository.Remove(existingCategory);
			await _categoryRepository.SaveChangesAsync();
			_logger.LogInfo($"Xóa thành công danh mục với Id {existingCategory.Id}");
		}

		public async Task<bool> CategoryExistsAsync(string categoryName)
		{
			return await _categoryRepository.CategoryExistsAsync(categoryName);
		}

		public async Task<CategoryDto> GetCategoryByNameAsync(string categoryName)
		{
			var category = await _categoryRepository
										.FindByCondition(c => c.Name == categoryName)
										.FirstOrDefaultAsync();

			if(category == null)
			{
				_logger.LogError($"Không tìm thấy danh mục với tên là {categoryName}.");
				throw new CategoryNotFoundException($"Không tìm thấy danh mục với tên là {categoryName}.");
			}
			 var categoryDto = _mapper.Map<CategoryDto>(category);
			return categoryDto;
		}
	}

}
