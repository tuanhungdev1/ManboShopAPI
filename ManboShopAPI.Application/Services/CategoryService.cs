using AutoMapper;
using ManboShopAPI.Application.Common.Constants;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.CategoryDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;
		private readonly IUnitOfWork _unitOfWork;
		private readonly ICloudinaryService _cloudinaryService;

		public CategoryService(ICategoryRepository categoryRepository,
								IMapper mapper,
								IUnitOfWork unitOfWork,
								ICloudinaryService cloudinaryService,
								ILoggerService loggerService
								)
		{
			_cloudinaryService = cloudinaryService;
			_unitOfWork = unitOfWork;
			_categoryRepository = categoryRepository;
			_mapper = mapper;
			_logger = loggerService;
		}

		public async Task<(IEnumerable<CategoryDto> categories, MetaData metaData)> GetAllCategoriesAsync(CategoryRequestParameters categoryRequestParameters)
		{
			var categories = await _categoryRepository.FetchAllCategoriesWithPaging(categoryRequestParameters);
			_logger.LogInfo("Lấy danh sách danh mục thành công.");
			var categoryDtoList = _mapper.Map<IEnumerable<CategoryDto>>(categories);
			return (categoryDtoList, metaData: categories.MetaData);
		}

		public async Task<CategoryDto> GetCategoryByIdAsync(int categoryId)
		{
			var category = await _categoryRepository
				.FindByCondition(c => c.Id == categoryId)
				.Include(c => c.SubCategories)
				.ThenInclude(sc => sc.SubCategories)
				.ThenInclude(sc => sc.SubCategories)
				.ThenInclude(sc => sc.SubCategories)
				.ThenInclude(sc => sc.SubCategories)
				.ThenInclude(sc => sc.SubCategories)
				.FirstOrDefaultAsync();
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
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				if(categoryForCreateDto.ParentCategoryId.HasValue && !await _categoryRepository.FindByCondition(c => c.Id == categoryForCreateDto.ParentCategoryId).AnyAsync())
				{
					_logger.LogError($"Không tìm thấy Parent Category với ID {categoryForCreateDto.ParentCategoryId}");
					throw new CategoryBadRequestException($"Không tìm thấy Parent Category trong hệ thống");
				}

				var existingCategory = await _unitOfWork.CategoryRepository
					.FindByCondition(c => c.Name == categoryForCreateDto.Name)
					.FirstOrDefaultAsync();

				if(existingCategory != null)
				{
					_logger.LogInfo($"Danh mục có tên ${categoryForCreateDto.Name} đã tồn tại");
					throw new CategoryBadRequestException($"Danh mục có tên ${categoryForCreateDto.Name} đã tồn tại");
				}

				var category = _mapper.Map<Category>(categoryForCreateDto);
				await _categoryRepository.AddAsync(category);
				
				await _categoryRepository.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo("Tạo danh mục mới thành công.");
			} catch (Exception)
			{
				_logger.LogError("Có lỗi xảy ra khi tạo mới danh mục");
				await _unitOfWork.RollbackAsync();
				throw;
			}
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

			if (categoryForUpdateDto.ParentCategoryId.HasValue && !await _categoryRepository.FindByCondition(c => c.Id == categoryForUpdateDto.ParentCategoryId).AnyAsync())
			{
				_logger.LogError($"Không tìm thấy Parent Category với ID {categoryForUpdateDto.ParentCategoryId}");
				throw new CategoryBadRequestException($"Không tìm thấy Parent Category trong hệ thống");
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

		public async Task CreateChildCategoriesAsync(int parentCategoryId, IEnumerable<string> childCategoryNames)
		{
			// Kiểm tra danh mục cha có tồn tại hay không
			var parentCategory = await _categoryRepository.GetByIdAsync(parentCategoryId);
			if (parentCategory == null)
			{
				_logger.LogError($"Không tìm thấy danh mục cha với ID {parentCategoryId}");
				throw new CategoryNotFoundException(parentCategoryId);
			}

			// Bắt đầu transaction
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				foreach (var childCategoryName in childCategoryNames)
				{
					// Kiểm tra xem danh mục con đã tồn tại chưa
					var existingChildCategory = await _categoryRepository
						.FindByCondition(c => c.Name == childCategoryName && c.ParentCategoryId == parentCategoryId)
						.FirstOrDefaultAsync();

					if (existingChildCategory != null)
					{
						_logger.LogWarning($"Danh mục con với tên '{childCategoryName}' đã tồn tại dưới danh mục cha với ID {parentCategoryId}");
						continue; // Bỏ qua danh mục này và tiếp tục với danh mục khác
					}

					// Tạo danh mục con mới
					var newChildCategory = new Category
					{
						Name = childCategoryName,
						ParentCategoryId = parentCategoryId,
						CreatedAt = DateTime.UtcNow,
						UpdatedAt = DateTime.UtcNow
					};

					await _categoryRepository.AddAsync(newChildCategory);
				}

				// Lưu thay đổi và commit transaction
				await _categoryRepository.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Tạo danh sách danh mục con thành công cho danh mục cha với ID {parentCategoryId}");
			}
			catch (Exception ex)
			{
				_logger.LogError($"Có lỗi xảy ra khi tạo danh sách danh mục con: {ex.Message}");
				await _unitOfWork.RollbackAsync();
				throw;
			}
		}
	}

}
