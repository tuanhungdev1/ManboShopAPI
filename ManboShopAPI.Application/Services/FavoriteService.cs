using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.BadRequest;
using ManboShopAPI.Domain.Exceptions.NotFound;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace ManboShopAPI.Application.Services
{
	public class FavoriteService : IFavoriteService
	{
		private readonly IFavoriteRepository _favoriteRepository;
		private readonly IProductRepository _productRepository;
		private readonly IUserRepository _userRepository;
		private readonly IMapper _mapper;
		private readonly ILogger<FavoriteService> _logger;

		public FavoriteService(IFavoriteRepository favoriteRepository,
							   IProductRepository productRepository,
							   IMapper mapper,
							   IUserRepository userRepository,
							   ILogger<FavoriteService> logger)
		{
			_favoriteRepository = favoriteRepository;
			_productRepository = productRepository;
			_userRepository = userRepository;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<IEnumerable<ProductDto>> GetUserFavoriteProductsAsync(ClaimsPrincipal user)
		{
			var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				_logger.LogError("Không tìm thấy thông tin người dùng từ token.");
				throw new UnauthorizedAccessException("Không có thông tin xác thực.");
			}


			if (!int.TryParse(userId, out int parsedUserId))
			{
				_logger.LogError($"Không thể chuyển đổi ID người dùng: {userId}");
				throw new UserBadRequestException("Định dạng ID người dùng không hợp lệ.");
			}
			var currentUser = await _userRepository.GetByIdAsync(parsedUserId);
			if (currentUser == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {userId}");
				throw new UserNotFoundException(userId);
			}

			var products = await _favoriteRepository.GetProductsByUserIdAsync(parsedUserId);
			_logger.LogInformation($"Lấy danh sách sản phẩm yêu thích cho người dùng với ID {userId} thành công.");
			return _mapper.Map<IEnumerable<ProductDto>>(products);
		}

		public async Task AddFavoriteAsync(ClaimsPrincipal user, FavoriteForCreateDto favoriteForCreateDto)
		{
			var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				_logger.LogError("Không tìm thấy thông tin người dùng từ token.");
				throw new UnauthorizedAccessException("Không có thông tin xác thực.");
			}


			if (!int.TryParse(userId, out int parsedUserId))
			{
				_logger.LogError($"Không thể chuyển đổi ID người dùng: {userId}");
				throw new UserBadRequestException("Định dạng ID người dùng không hợp lệ.");
			}
			var existingFavorite = await _favoriteRepository.FindByCondition(f => f.UserId == parsedUserId && f.ProductId == favoriteForCreateDto.ProductId).FirstOrDefaultAsync();

			if (existingFavorite != null)
			{
				_logger.LogError($"Sản phẩm đã tồn tại trong danh sách yêu thích của người dùng");
				throw new FavoriteBadRequestException($"Sản phẩm đã tồn tại trong danh sách yêu thích của người dùng");
			}

			var product = await _productRepository.GetByIdAsync(favoriteForCreateDto.ProductId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với ID {favoriteForCreateDto.ProductId}");
				throw new ProductNotFoundException(favoriteForCreateDto.ProductId);
			}

			var currentUser = await _userRepository.GetByIdAsync(parsedUserId);

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {userId}");
				throw new UserNotFoundException(userId);
			}
			var favorite = new Favorite
			{
				UserId = parsedUserId,
				ProductId = favoriteForCreateDto.ProductId
			};
			await _favoriteRepository.AddAsync(favorite);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Thêm sản phẩm với ID {favoriteForCreateDto.ProductId} vào danh sách yêu thích của người dùng với ID {userId} thành công.");
		}

		public async Task RemoveFavoriteAsync(ClaimsPrincipal user, FavoriteForCreateDto favoriteForCreateDto)
		{
			var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				_logger.LogError("Không tìm thấy thông tin người dùng từ token.");
				throw new UnauthorizedAccessException("Không có thông tin xác thực.");
			}


			if (!int.TryParse(userId, out int parsedUserId))
			{
				_logger.LogError($"Không thể chuyển đổi ID người dùng: {userId}");
				throw new UserBadRequestException("Định dạng ID người dùng không hợp lệ.");
			}

			var product = await _productRepository.GetByIdAsync(favoriteForCreateDto.ProductId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với ID {favoriteForCreateDto.ProductId}");
				throw new ProductNotFoundException(favoriteForCreateDto.ProductId);
			}

			var favorite = await _favoriteRepository.FindByCondition(f => f.UserId == parsedUserId && f.ProductId == product.Id).FirstOrDefaultAsync();
			if (favorite == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm yêu thích trong danh sách yêu thích của User.");
				throw new FavoriteNotFoundException($"Lấy danh sách sản phẩm yêu thích cho người dùng thành công sách yêu thích");
			}

			_favoriteRepository.Remove(favorite);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Xóa sản phẩm yêu thích với ID {favoriteForCreateDto.ProductId} thành công.");
		}

		public async Task<bool> IsFavoriteAsync(int userId, int productId)
		{
			var favorite = await _favoriteRepository.FindByCondition(f => f.UserId == userId && f.ProductId == productId).FirstOrDefaultAsync();
			return favorite != null;
		}

		public async Task<Favorite> GetFavoriteAsync(int userId, int productId)
		{
			return await _favoriteRepository.FindByCondition(f => f.UserId == userId && f.ProductId == productId).FirstOrDefaultAsync();
		}

		public async Task<IEnumerable<Favorite>> GetFavoritesByUserIdAsync(int userId)
		{
			return await _favoriteRepository.FindByCondition(f => f.UserId == userId).ToListAsync();
		}

		public async Task RemoveFavoriteAsync(int userId, int productId)
		{
			var favorite = await _favoriteRepository.FindByCondition(f => f.UserId == userId && f.ProductId == productId).FirstOrDefaultAsync();
			if (favorite == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm yêu thích với ID {productId} trong danh sách yêu thích của người dùng với ID {userId}");
				throw new FavoriteNotFoundException($"Không tìm thấy sản phẩm yêu thích với ID {productId} trong danh sách yêu thích của người dùng với ID {userId}");
			}

			_favoriteRepository.Remove(favorite);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Xóa sản phẩm yêu thích với ID {productId} trong danh sách yêu thích của người dùng với ID {userId} thành công.");
		}

		public async Task RemoveFavoritesByUserIdAsync(int userId)
		{
			var favorites = await _favoriteRepository.FindByCondition(f => f.UserId == userId).ToListAsync();
			_favoriteRepository.RemoveRange(favorites);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Xóa tất cả sản phẩm yêu thích của người dùng với ID {userId} thành công.");
		}

		public async Task<int> GetCountFavoriteForCurrentUser(ClaimsPrincipal user)
		{
			var userId = int.Parse(user.FindFirst(ClaimTypes.NameIdentifier).Value);
			return await _favoriteRepository.FindByCondition(f => f.UserId == userId).CountAsync();
		}
	}
}