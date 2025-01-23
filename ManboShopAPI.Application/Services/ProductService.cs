using AutoMapper;
using Bogus.DataSets;
using ManboShopAPI.Application.Common.Constants;
using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.AttributeDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.DTOs.ProductImageDtos;
using ManboShopAPI.Application.DTOs.VariantDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
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
		private readonly IVariantRepository _variantRepository;
		private readonly IVariantValueRepository _variantValueRepository;
		private readonly IProductVariantValueRepository _productVariantValueRepository;

		public ProductService(
			IProductVariantValueRepository productVariantValueRepository,
			IVariantValueRepository variantValueRepository,
			IVariantRepository variantRepository,
			IProductRepository productRepository,
			ICloudinaryService cloudinaryService,
			ICategoryRepository categoryRepository,
			IBrandRepository brandRepository,
			IProductImageRepository productImageRepository,
			IUnitOfWork unitOfWork,
			IMapper mapper,
			ILoggerService logger)
		{
			_productVariantValueRepository = productVariantValueRepository;
			_variantValueRepository = variantValueRepository;
			_productRepository = productRepository;
			_categoryRepository = categoryRepository;
			_brandRepository = brandRepository;
			_unitOfWork = unitOfWork;
			_cloudinaryService = cloudinaryService;
			_productImageRepository = productImageRepository;
			_mapper = mapper;
			_logger = logger;
			_variantRepository = variantRepository;
		}

		public async Task<ProductDto> GetProductBySlugNameAsync(string slugName)
		{	
			var product = await _productRepository.FindByCondition(p => p.SlugName == slugName)
				.Include(p => p.Brand)
				.Include(p => p.Category)
				.Include(p => p.ProductImages)
				.Include(p => p.ProductAttributeValues)
					.ThenInclude(pav => pav.Attribute)
				.Include(p => p.ProductVariantValues)
				.FirstOrDefaultAsync();

			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với slug name {slugName}");
				throw new ProductNotFoundException(slugName);
			}
			
			_logger.LogInfo($"Lấy thông tin sản phẩm với slug name {slugName} thành công.");
			return _mapper.Map<ProductDto>(product);
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
							.Include(p => p.ProductAttributeValues)
								.ThenInclude(pav => pav.Attribute)
							.Include(p => p.ProductVariantValues)
							.FirstOrDefaultAsync();
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với id {id}");
				throw new ProductNotFoundException(id);
			}

			_logger.LogInfo($"Lấy thông tin sản phẩm với id {id} thành công.");
			var productDto = _mapper.Map<ProductDto>(product);
			

			return productDto;
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

				// 1. Validate cơ bản
				await ValidateProductData(productDto.CategoryId, productDto.BrandId);

				if (await _productRepository.ProductNameExistsAsync(productDto.Name))
				{
					_logger.LogError($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
					throw new ProductBadRequestException($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
				}

				if (productDto.Images?.Count > 20)
				{
					_logger.LogError("Số lượng hình ảnh vượt quá giới hạn cho phép (tối đa 20 hình)");
					throw new ProductBadRequestException("Chỉ được phép upload tối đa 20 hình ảnh cho sản phẩm");
				}

				// 2. Tạo product cơ bản
				var product = _mapper.Map<Product>(productDto);
				product.SlugName = SlugHelper.ConvertToSlug(product.Name);
				await _productRepository.AddAsync(product);
				await _productRepository.SaveChangesAsync();

				// 3. Xử lý images
				var productImages = new List<ProductImage>();
				if (productDto.Images?.Any() == true)
				{
					string folder = FileConstants.GetFullPath("products", $"PRODUCT_{product.Id}/");
					foreach (var image in productDto.Images)
					{
						string imageUrl = await _cloudinaryService.UploadImageAsync(image, folder, $"{FileConstants.FileNames.ProductImage}_{product.Id}");
						productImages.Add(new ProductImage
						{
							ProductId = product.Id,
							ImageUrl = imageUrl
						});
					}
					await _productImageRepository.AddRangeAsync(productImages);
					await _productImageRepository.SaveChangesAsync();
				}

				// 4. Xử lý attributes
				var existingAttributes = await _unitOfWork.AttributeRepository
			.FindByCondition(a => productDto.AttributeForCreateDtos
				.Select(x => x.Name)
				.Contains(a.Name))
			.ToDictionaryAsync(a => a.Name, a => a);

				var newAttributes = new List<Attributes>();

				// Tạo attributes mới nếu chưa tồn tại
				foreach (var attrDto in productDto.AttributeForCreateDtos)
				{
					if (!existingAttributes.ContainsKey(attrDto.Name))
					{
						var newAttribute = new Attributes { Name = attrDto.Name };
						newAttributes.Add(newAttribute);
					}
				}

				// Lưu attributes mới và cập nhật dictionary
				if (newAttributes.Any())
				{
					await _unitOfWork.AttributeRepository.AddRangeAsync(newAttributes);
					await _unitOfWork.AttributeRepository.SaveChangesAsync();

					foreach (var attr in newAttributes)
					{
						existingAttributes[attr.Name] = attr;
					}
				}

				// Tạo và lưu product attribute values
				var productAttributeValues = productDto.AttributeForCreateDtos
					.Select(attrDto => new ProductAttributeValue
					{
						ProductId = product.Id,
						AttributeId = existingAttributes[attrDto.Name].Id,
						Value = attrDto.Value
					})
					.ToList();

				await _unitOfWork.ProductAttributeValueRepository.AddRangeAsync(productAttributeValues);
				await _unitOfWork.ProductAttributeValueRepository.SaveChangesAsync();

				// 5. Xử lý variants
				var variantValues = new List<VariantValue>();
				var productVariantValues = new List<ProductVariantValue>();

				foreach (var variantDto in productDto.Variants)
				{
					var productVariant = await _variantRepository.GetOrCreateAsync(
						v => v.Name == variantDto.Name,
						() => new Variant { Name = variantDto.Name }
					);

					foreach (var valueDto in variantDto.Values)
					{
						var variantValue = new VariantValue
						{
							VariantId = productVariant.Id,
							Value = valueDto.Value,
							CreatedAt = DateTime.UtcNow
						};

						if (valueDto.FileImage != null)
						{
							string folder = FileConstants.GetFullPath("products", $"PRODUCT_{product.Id}/VARIANT_{productVariant.Name}_{productVariant.Id}/");
							variantValue.ImageUrl = await _cloudinaryService.UploadImageAsync(
								valueDto.FileImage,
								folder,
								FileConstants.FileNames.ProductVariantImage
							);
						}

						variantValues.Add(variantValue);
					}
				}

				if (variantValues.Any())
				{
					await _variantValueRepository.AddRangeAsync(variantValues);
					await _variantValueRepository.SaveChangesAsync();
				}

				// 6. Xử lý product variant values
				foreach (var pvValueDto in productDto.VariantValues)
				{
					if (pvValueDto.VariantCombination.Count() < 2)
					{
						throw new ProductBadRequestException("Thiếu giá trị để kết hợp thành một biến thể của sản phẩm");
					}

					var variantValueIds = variantValues.Where(predicate => pvValueDto.VariantCombination.Contains(predicate.Value)).Select(selector => selector.Id).ToList();

					if (variantValueIds.Count != pvValueDto.VariantCombination.Count())
					{
						throw new ProductBadRequestException("Không tìm thấy giá trị của biến thể sản phẩm khi tạo một biến thể sản phẩm");
					}

					variantValueIds.Sort();
					var sku = string.Join("-", variantValueIds);

					productVariantValues.Add(new ProductVariantValue
					{
						ProductId = product.Id,
						OldPrice = pvValueDto.OldPrice,
						Price = pvValueDto.Price,
						Stock = pvValueDto.Stock,
						Sku = sku,
						CreatedAt = DateTime.UtcNow,
						UpdatedAt = DateTime.UtcNow
					});
				}

				if (productVariantValues.Any())
				{
					await _productVariantValueRepository.AddRangeAsync(productVariantValues);
					await _productVariantValueRepository.SaveChangesAsync();
				}

				// 7. Return minimal product DTO
				var productImageDtos = _mapper.Map<IEnumerable<ProductImageDto>>(productImages);
				var productDTO = new ProductDto
				{
					Id = product.Id,
					Name = product.Name,
					Description = product.Description,
					Price = product.Price,
					ProductImages = productImageDtos.ToList(),
					CreatedAt = product.CreatedAt,
					UpdatedAt = product.UpdatedAt
				};

				await _unitOfWork.CommitAsync();
				_logger.LogInfo($"Tạo sản phẩm mới '{product.Name}' thành công.");
				return productDTO;
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Tạo sản phẩm mới '{productDto.Name}' thất bại.");
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
					.Include(p => p.ProductImages)
					.Include(p => p.ProductAttributeValues)
					.Include(p => p.ProductVariantValues)
					.FirstOrDefaultAsync();

				if (existingProduct == null)
				{
					_logger.LogError($"Không tìm thấy sản phẩm với id {productId}");
					throw new ProductNotFoundException(productId);
				}

				await ValidateProductData(productDto.CategoryId, productDto.BrandId);

				// Kiểm tra trùng tên sản phẩm
				if (await _productRepository.ProductNameExistsAsync(productDto.Name) &&
					existingProduct.Name != productDto.Name)
				{
					throw new ProductBadRequestException($"Sản phẩm với tên '{productDto.Name}' đã tồn tại.");
				}

				// 1. Xử lý cập nhật hình ảnh
				await UpdateProductImagesAsync(existingProduct, productDto.Images);

				// 2. Cập nhật thông tin thuộc tính sản phẩm
				await UpdateProductAttributesAsync(productId, productDto.AttributeForUpdateDtos);

				// 3. Cập nhật variants và variant values
				await UpdateProductVariantsAsync(productId, productDto.Variants);

				// 4. Cập nhật product variant values
				await UpdateProductVariantValuesAsync(productId, productDto.VariantValues);

				// 5. Cập nhật thông tin cơ bản của sản phẩm
				_mapper.Map(productDto, existingProduct);
				existingProduct.UpdatedAt = DateTime.UtcNow;
				_productRepository.Update(existingProduct);
				await _productRepository.SaveChangesAsync();

				// 6. Lấy thông tin sản phẩm đã cập nhật
				var updatedProduct = await _productRepository
					.FindByCondition(p => p.Id == productId)
					.Include(p => p.Category)
					.Include(p => p.Brand)
					.Include(p => p.ProductImages)
					.Include(p => p.ProductAttributeValues)
						.ThenInclude(pav => pav.Attribute)
					.Include(p => p.ProductVariantValues)
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
					.Include(p => p.ProductAttributeValues)
					.Include(p => p.ProductVariantValues)
					.Include(p => p.Favorites)
					.Include(p => p.NewsDetails)
					.Include(p => p.BannerDetails)
					.FirstOrDefaultAsync();

				if (existingProduct == null)
				{
					throw new ProductNotFoundException(productId);
				}

				// 1. Xóa hình ảnh sản phẩm
				if (existingProduct.ProductImages?.Any() == true)
				{
					foreach (var image in existingProduct.ProductImages)
					{
						var publicId = _cloudinaryService.GetPublicIdFromUrl(image.ImageUrl);
						await _cloudinaryService.DeleteImageAsync(publicId);
					}
					_productImageRepository.RemoveRange(existingProduct.ProductImages);
					await _productImageRepository.SaveChangesAsync();
				}

				// 2. Xóa cart items
				var cartItems = await _unitOfWork.CartItemRepository
					.FindByCondition(ci => ci.ProductId == productId)
					.ToListAsync();
				_unitOfWork.CartItemRepository.RemoveRange(cartItems);

				// 3. Xóa product attributes
				_unitOfWork.ProductAttributeValueRepository.RemoveRange(existingProduct.ProductAttributeValues);

				// 4. Xóa product variant values
				_unitOfWork.ProductVariantValueRepository.RemoveRange(existingProduct.ProductVariantValues);

				// 5. Xóa order details
				var orderDetails = await _unitOfWork.OrderDetailRepository
					.FindByCondition(od => od.ProductId == productId)
					.ToListAsync();
				_unitOfWork.OrderDetailRepository.RemoveRange(orderDetails);

				// 6. Xóa favorites
				_unitOfWork.FavoriteRepository.RemoveRange(existingProduct.Favorites);

				// 7. Xóa news details
				_unitOfWork.NewsDetailRepository.RemoveRange(existingProduct.NewsDetails);

				// 8. Xóa banner details
				_unitOfWork.BannerDetailRepository.RemoveRange(existingProduct.BannerDetails);

				// 9. Xóa sản phẩm
				_productRepository.Remove(existingProduct);

				// 10. Lưu các thay đổi
				await _unitOfWork.SaveChangesAsync();
				await _unitOfWork.CommitAsync();

				_logger.LogInfo($"Xóa sản phẩm với id {productId} thành công.");
			}
			catch (Exception)
			{
				await _unitOfWork.RollbackAsync();
				_logger.LogError($"Xóa sản phẩm với id {productId} thất bại.");
				throw;
			}
		}

		// Các phương thức hỗ trợ
		private async Task UpdateProductImagesAsync(Product existingProduct, ICollection<IFormFile> newImages)
		{
			if (newImages?.Any() == true)
			{
				// Xóa ảnh cũ
				foreach (var image in existingProduct.ProductImages)
				{
					var publicId = _cloudinaryService.GetPublicIdFromUrl(image.ImageUrl);
					await _cloudinaryService.DeleteImageAsync(publicId);
				}
				_productImageRepository.RemoveRange(existingProduct.ProductImages);
				await _productImageRepository.SaveChangesAsync();

				// Upload ảnh mới
				string folder = FileConstants.GetFullPath("products", $"PRODUCT_{existingProduct.Id}/");
				foreach (var image in newImages)
				{
					string imageUrl = await _cloudinaryService.UploadImageAsync(image, folder,
						$"{FileConstants.FileNames.ProductImage}_{existingProduct.Id}");
					await _productImageRepository.AddAsync(new ProductImage
					{
						ProductId = existingProduct.Id,
						ImageUrl = imageUrl
					});
				}
				await _productImageRepository.SaveChangesAsync();
			}
		}

		private async Task UpdateProductAttributesAsync(int productId, ICollection<AttributeForUpdateDto> attributes)
		{
			if (attributes?.Any() == true)
			{
				var existingAttributes = await _unitOfWork.ProductAttributeValueRepository
					.FindByCondition(pav => pav.ProductId == productId)
					.Include(pav => pav.Attribute)
					.ToListAsync();

				foreach (var attributeDto in attributes)
				{
					var existingAttribute = existingAttributes
						.FirstOrDefault(ea => ea.Attribute.Name == attributeDto.Name);

					if (existingAttribute != null)
					{
						existingAttribute.Value = attributeDto.Value;
						_unitOfWork.ProductAttributeValueRepository.Update(existingAttribute);
					}
					else
					{
						// Tạo attribute mới nếu chưa tồn tại
						var newAttribute = await _unitOfWork.AttributeRepository
							.GetOrCreateAsync(a => a.Name == attributeDto.Name,
								() => new Attributes { Name = attributeDto.Name });

						await _unitOfWork.ProductAttributeValueRepository.AddAsync(
							new ProductAttributeValue
							{
								ProductId = productId,
								AttributeId = newAttribute.Id,
								Value = attributeDto.Value
							});
					}
				}
				await _unitOfWork.ProductAttributeValueRepository.SaveChangesAsync();
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

		private async Task UpdateProductVariantsAsync(int productId, ICollection<VariantForUpdateDto> variantDtos)
		{
			if (variantDtos?.Any() != true) return;

			var variantValuePairs = new List<(int variantValueId, string value)>();

			// Bước 1: Xử lý và lưu các Variant và VariantValue
			foreach (var variantDto in variantDtos)
			{
				// Lấy hoặc tạo mới variant
				var variant = await _variantRepository.GetOrCreateAsync(
					v => v.Name == variantDto.Name,
					() => new Variant { Name = variantDto.Name }
				);

				foreach (var valueDto in variantDto.Values)
				{
					// Kiểm tra hoặc tạo mới VariantValue
					var variantValue = await _variantValueRepository.GetOrCreateAsync(
						vv => vv.VariantId == variant.Id && vv.Value == valueDto.Value,
						() => new VariantValue
						{
							VariantId = variant.Id,
							Value = valueDto.Value,
							CreatedAt = DateTime.UtcNow
						}
					);

					// Xử lý upload ảnh nếu có
					if (valueDto.FileImage != null)
					{
						if (!string.IsNullOrEmpty(variantValue.ImageUrl))
						{
							var publicId = _cloudinaryService.GetPublicIdFromUrl(variantValue.ImageUrl);
							await _cloudinaryService.DeleteImageAsync(publicId);
						}

						string folder = FileConstants.GetFullPath("products",
							$"PRODUCT_{productId}/VARIANT_{variant.Name}_{variant.Id}/");
						variantValue.ImageUrl = await _cloudinaryService.UploadImageAsync(
							valueDto.FileImage,
							folder,
							FileConstants.FileNames.ProductVariantImage
						);

						_variantValueRepository.Update(variantValue);
					}

					variantValuePairs.Add((variantValue.Id, variantValue.Value));
				}
			}

			// Bước 2: Tạo combinations từ các VariantValue
			var combinations = GenerateCombinations(variantValuePairs);

			// Bước 3: Tạo hoặc cập nhật ProductVariantValue cho mỗi combination
			foreach (var combination in combinations)
			{
				string sku = string.Join("-", combination.Select(x => x.variantValueId).OrderBy(x => x));

				var productVariant = await _productVariantValueRepository
					.FindByCondition(pv => pv.ProductId == productId && pv.Sku == sku)
					.FirstOrDefaultAsync();

				if (productVariant == null)
				{
					productVariant = new ProductVariantValue
					{
						ProductId = productId,
						Sku = sku,
						Price = 0, // Set default value
						OldPrice = 0, // Set default value
						Stock = 0, // Set default value
						CreatedAt = DateTime.UtcNow
					};
					await _productVariantValueRepository.AddAsync(productVariant);
				}
			}

			await _unitOfWork.SaveChangesAsync();
		}

		private List<List<(int variantValueId, string value)>> GenerateCombinations(List<(int variantValueId, string value)> variantValuePairs)
		{
			var variants = variantValuePairs
				.GroupBy(x => x.value)
				.Select(g => g.ToList())
				.ToList();

			var result = new List<List<(int variantValueId, string value)>>();
			var current = new List<(int variantValueId, string value)>();

			void Generate(int variantIndex)
			{
				if (variantIndex == variants.Count)
				{
					result.Add(new List<(int variantValueId, string value)>(current));
					return;
				}

				foreach (var value in variants[variantIndex])
				{
					current.Add(value);
					Generate(variantIndex + 1);
					current.RemoveAt(current.Count - 1);
				}
			}

			Generate(0);
			return result;
		}

		private async Task UpdateProductVariantValuesAsync(int productId,
			ICollection<ProductVariantValueForUpdateDto> variantValueDtos)
		{
			if (variantValueDtos?.Any() == true)
			{
				// Xóa tất cả product variant values hiện tại
				var existingPVValues = await _productVariantValueRepository
					.FindByCondition(pvv => pvv.ProductId == productId)
					.ToListAsync();
				_productVariantValueRepository.RemoveRange(existingPVValues);
				await _productVariantValueRepository.SaveChangesAsync();

				// Tạo product variant values mới
				foreach (var pvValueDto in variantValueDtos)
				{
					if (pvValueDto.VariantCombination.Count() < 2)
					{
						throw new ProductBadRequestException(
							"Thiếu giá trị để kết hợp thành một biến thể của sản phẩm");
					}

					var variantValueIds = await _variantValueRepository
						.FindByCondition(vv => pvValueDto.VariantCombination.Contains(vv.Value))
						.Select(vv => vv.Id)
						.ToListAsync();

					if (variantValueIds.Count != pvValueDto.VariantCombination.Count())
					{
						throw new ProductBadRequestException(
							"Không tìm thấy giá trị của biến thể sản phẩm khi cập nhật biến thể sản phẩm");
					}

					variantValueIds.Sort();
					var sku = string.Join("-", variantValueIds);

					await _productVariantValueRepository.AddAsync(new ProductVariantValue
					{
						ProductId = productId,
						OldPrice = pvValueDto.OldPrice,
						Price = pvValueDto.Price,
						Stock = pvValueDto.Stock,
						Sku = sku,
						CreatedAt = DateTime.UtcNow,
						UpdatedAt = DateTime.UtcNow
					});
				}

				await _productVariantValueRepository.SaveChangesAsync();
			}
		}
	}
}
