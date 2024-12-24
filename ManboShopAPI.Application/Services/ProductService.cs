using AutoMapper;
using ManboShopAPI.Application.Common.Constants;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Application.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly ICategoryRepository _categoryRepository;
		private readonly IBrandRepository _brandRepository;
		private readonly ICloudinaryService _cloudinaryService;
		private readonly IProductImageRepository _productImageRepository;
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;
		private readonly ILoggerService _logger;

		public ProductService(
			IProductRepository productRepository,
			ICloudinaryService cloudinaryService,
			ICategoryRepository categoryRepository,
			IBrandRepository brandRepository,
			IProductImageRepository productImageRepository,
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
			_brandRepository = brandRepository;
			_unitOfWork = unitOfWork;
			_cloudinaryService = cloudinaryService;
			_productImageRepository = productImageRepository;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<(IEnumerable<ProductDto> products, MetaData metaData)> GetAllProductsAsync(ProductRequestParameters productRequestParameters)
		{
			var products = await _productRepository.GetProductsWithDetailsAsync(productRequestParameters);
			_logger.LogInfo("Lấy danh sách sản phẩm thành công.");
			var productDtoList = _mapper.Map<IEnumerable<ProductDto>>(products);
			return (productDtoList, products.MetaData);
		}

		public async Task<ProductDto> GetProductByIdAsync(int id)
		{
			var product = await _productRepository
							.FindByCondition(p => p.Id == id)
							.Include(p => p.Category)
							.Include(p => p.Brand)
							.Include(p => p.ProductImages)
							.FirstOrDefaultAsync();
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {id}");
				throw new ProductNotFoundException(id);
			}

			_logger.LogInfo($"Lấy thông tin sản phẩm với id {id} thành công.");
			return _mapper.Map<ProductDto>(product);
		}

		public async Task<IEnumerable<ProductDto>> GetProductsByCategoryAsync(int categoryId)
		{
			var category = await _categoryRepository.GetByIdAsync(categoryId);
			if(category == null)
			{
				_logger.LogError($"Không tìm thấy danh mục với id {categoryId}");
				throw new CategoryNotFoundException(categoryId);
			}

			var products = await _productRepository.GetProductsByCategoryIdAsync(categoryId);
			_logger.LogInfo($"Lấy danh sách sản phẩm theo danh mục id {categoryId} thành công.");
			return _mapper.Map<IEnumerable<ProductDto>>(products);
		}

		public async Task<IEnumerable<ProductDto>> GetProductsByBrandAsync(int brandId)
		{

			var brand = await _brandRepository.GetByIdAsync(brandId);

			if(brand == null)
			{
				_logger.LogError($"Không tìm thấy thương hiệu với id {brandId}");
				throw new BrandNotFoundException(brandId);
			}

			var products = await _productRepository.GetProductsByBrandIdAsync(brandId);
			_logger.LogInfo($"Lấy danh sách sản phẩm theo thương hiệu id {brandId} thành công.");
			return _mapper.Map<IEnumerable<ProductDto>>(products);
		}

		public async Task<ProductDto> CreateProductAsync(ProductForCreateDto productDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();
				await ValidateProductData(productDto.CategoryId, productDto.BrandId);

				if (await _productRepository.ProductNameExistsAsync(productDto.Name))
				{
					_logger.LogError($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
					throw new ProductBadRequestException($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
				}

				if (productDto.Images.Count != null && productDto.Images.Count > 5)
				{
					_logger.LogError("Số lượng hình ảnh vượt quá giới hạn cho phép (tối đa 5 hình)");
					throw new ProductBadRequestException("Chỉ được phép upload tối đa 5 hình ảnh cho sản phẩm");
				}

				var product = _mapper.Map<Product>(productDto);
				await _productRepository.AddAsync(product);
				await _productRepository.SaveChangesAsync();

				if(productDto.Images != null && productDto.Images.Any())
				{
					string folder = $"ManboShopAPI/{FileConstants.FoldersName.Products}/PRODUCT_{product.Id}/";

					foreach(var image in productDto.Images)
					{
						string imageUrl = await _cloudinaryService.UploadImageAsync(image, folder, $"{FileConstants.FileName.ProductImage}_{product.Id}");

						var productImage = new ProductImage
						{
							ProductId = product.Id,
							ImageUrl = imageUrl
						};

						await _productImageRepository.AddAsync(productImage);
					}

					await _productImageRepository.SaveChangesAsync();
					_logger.LogInfo($"Upload hình ảnh cho sản phẩm '{product.Name}' thành công.");
				}

				var newProduct = await _productRepository
								.FindByCondition(p => p.Id == product.Id)
								.Include(p => p.Category)
								.Include(p => p.Brand)
								.Include(p => p.ProductImages)
								.FirstOrDefaultAsync();

				
				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Tạo sản phẩm mới '{product.Name}' thành công.");
				return _mapper.Map<ProductDto>(newProduct);
			} catch(Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogInfo($"Tạo sản phẩm mới '{productDto.Name}' thất bại.");
				throw;
			}
		}

		public async Task<ProductDto> UpdateProductAsync(int productId, ProductForUpdateDto productDto)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();

				var existingProduct = await _productRepository
					.FindByCondition(p => p.Id == productId)
					.Include(p => p.ProductImages) // Include ProductImages để lấy danh sách ảnh hiện tại
					.FirstOrDefaultAsync();

				if (existingProduct == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
					throw new ProductNotFoundException(productId);
				}

				await ValidateProductData(productDto.CategoryId, productDto.BrandId);

				if (await _productRepository.ProductNameExistsAsync(productDto.Name) &&
					existingProduct.Name != productDto.Name)
				{
					_logger.LogError($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
					throw new ProductBadRequestException($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
				}

				if (productDto.Images != null && productDto.Images.Count > 5)
				{
					_logger.LogError("Số lượng hình ảnh vượt quá giới hạn cho phép (tối đa 5 hình)");
					throw new ProductBadRequestException("Chỉ được phép upload tối đa 5 hình ảnh cho sản phẩm");
				}

				// Xử lý cập nhật hình ảnh
				if (productDto.Images != null && productDto.Images.Any())
				{
					// Xóa các ảnh cũ từ Cloudinary và database
					if (existingProduct.ProductImages != null)
					{
						foreach (var image in existingProduct.ProductImages)
						{
							var publicId = _cloudinaryService.GetPublicIdFromUrl(image.ImageUrl);
							await _cloudinaryService.DeleteImageAsync(publicId);
							_productImageRepository.Remove(image);
						}
						await _productImageRepository.SaveChangesAsync();
						_logger.LogInfo($"Xóa hình ảnh cũ của sản phẩm '{existingProduct.Name}' thành công.");
					}

					// Upload ảnh mới
					string folder = $"ManboShopAPI/{FileConstants.FoldersName.Products}/PRODUCT_{existingProduct.Id}/";
					foreach (var image in productDto.Images)
					{
						string imageUrl = await _cloudinaryService.UploadImageAsync(image, folder, $"{FileConstants.FileName.ProductImage}_{existingProduct.Id}");
						var productImage = new ProductImage
						{
							ProductId = existingProduct.Id,
							ImageUrl = imageUrl
						};
						await _productImageRepository.AddAsync(productImage);
					}
					await _productImageRepository.SaveChangesAsync();
					_logger.LogInfo($"Upload hình ảnh mới cho sản phẩm '{existingProduct.Name}' thành công.");
				}

				// Cập nhật thông tin sản phẩm
				_mapper.Map(productDto, existingProduct);
				existingProduct.UpdatedAt = DateTime.UtcNow;
				_productRepository.Update(existingProduct);
				await _productRepository.SaveChangesAsync();

				// Lấy thông tin sản phẩm đã cập nhật
				var updatedProduct = await _productRepository
					.FindByCondition(p => p.Id == productId)
					.Include(p => p.Category)
					.Include(p => p.Brand)
					.Include(p => p.ProductImages)
					.FirstOrDefaultAsync();

				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Cập nhật sản phẩm với id {existingProduct.Id} thành công.");
				return _mapper.Map<ProductDto>(updatedProduct);
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Cập nhật sản phẩm với id {productId} thất bại.");
				throw;
			}
		}

		public async Task DeleteProductAsync(int productId)
		{
			try
			{
				await _unitOfWork.BeginTransactionAsync();
				var existingProduct = await _productRepository
								.FindByCondition(p => p.Id == productId)
								.Include(p => p.ProductImages)
								.FirstOrDefaultAsync();
				if (existingProduct == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
					throw new ProductNotFoundException(productId);
				}
				
				if(existingProduct.ProductImages != null)
				{
					foreach(var image in existingProduct.ProductImages)
					{
						var publicId = _cloudinaryService.GetPublicIdFromUrl(image.ImageUrl);
						await _cloudinaryService.DeleteImageAsync(publicId);
						_productImageRepository.Remove(image);
					}
					await _productImageRepository.SaveChangesAsync();
					_logger.LogInfo($"Xóa hình ảnh của sản phẩm với id {productId} thành công.");
				}
				_logger.LogInfo($"Xóa hình ảnh của sản phẩm với id {productId} thành công.");
				_productRepository.Remove(existingProduct);
				await _productRepository.SaveChangesAsync();
				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Xóa sản phẩm với id {productId} thành công.");
			} catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Xóa sản phẩm với id {productId} thất bại.");
				throw;
			}
		}

		public async Task<bool> ProductExistsAsync(int id)
		{
			return await _productRepository.ProductExistsAsync(id);
		}

		public async Task UpdateProductQuantityAsync(int id, int quantity)
		{
			var product = await _productRepository.GetByIdAsync(id);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {id}");
				throw new ProductNotFoundException(id);
			}

			if (quantity < 0)
			{
				_logger.LogError("Số lượng sản phẩm không thể âm.");
				throw new ProductBadRequestException("Số lượng sản phẩm không thể âm.");
			}

			product.Quantity = quantity;
			product.UpdatedAt = DateTime.UtcNow;
			_productRepository.Update(product);
			await _productRepository.SaveChangesAsync();
			_logger.LogInfo($"Cập nhật số lượng sản phẩm id {id} thành công. Số lượng mới: {quantity}");
		}

		private async Task ValidateProductData(int? categoryId, int? brandId)
		{
			if (categoryId.HasValue && !await _categoryRepository.CategoryExistsByIdAsync(categoryId.Value))
			{
				_logger.LogError($"Không tìm thấy danh mục với id {categoryId}");
				throw new CategoryNotFoundException(categoryId.Value);
			}

			if (brandId.HasValue && !await _brandRepository.BrandExistsByIdAsync(brandId.Value))
			{
				_logger.LogError($"Không tìm thấy thương hiệu với id {brandId}");
				throw new BrandNotFoundException(brandId.Value);
			}
		}
	}
}
