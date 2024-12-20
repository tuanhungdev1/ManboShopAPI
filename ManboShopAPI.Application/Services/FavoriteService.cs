using AutoMapper;
using ManboShopAPI.Application.Contracts;
using ManboShopAPI.Application.DTOs;
using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Exceptions.NotFound;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

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

		public async Task<IEnumerable<ProductDto>> GetUserFavoriteProductsAsync(int userId)
		{
			var user = await _userRepository.GetByIdAsync(userId);

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {userId}");
				throw new UserNotFoundException(userId);
			}

			var products = await _favoriteRepository.GetProductsByUserIdAsync(userId);
			_logger.LogInformation($"Lấy danh sách sản phẩm yêu thích cho người dùng với ID {userId} thành công.");
			return _mapper.Map<IEnumerable<ProductDto>>(products);
		}

		public async Task AddFavoriteAsync(FavoriteForCreateDto favoriteForCreateDto)
		{
			var existingFavorite = await _favoriteRepository.FindByCondition(f => f.UserId == favoriteForCreateDto.UserId && f.ProductId == favoriteForCreateDto.ProductId).FirstOrDefaultAsync();

			if (existingFavorite != null)
			{
				_logger.LogError($"Sản phẩm với ID {favoriteForCreateDto.ProductId} đã tồn tại trong danh sách yêu thích của người dùng với ID {favoriteForCreateDto.UserId}");
				throw new FavoriteBadRequestException($"Sản phẩm với ID {favoriteForCreateDto.ProductId} đã tồn tại trong danh sách yêu thích của người dùng với ID {favoriteForCreateDto.UserId}");
			}

			var product = await _productRepository.GetByIdAsync(favoriteForCreateDto.ProductId);
			if (product == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm với ID {favoriteForCreateDto.ProductId}");
				throw new ProductNotFoundException(favoriteForCreateDto.ProductId);
			}

			var user = await _userRepository.GetByIdAsync(favoriteForCreateDto.UserId);

			if (user == null)
			{
				_logger.LogError($"Không tìm thấy người dùng với ID {favoriteForCreateDto.UserId}");
				throw new UserNotFoundException(favoriteForCreateDto.UserId);
			}
			var favorite = new Favorite
			{
				UserId = favoriteForCreateDto.UserId,
				ProductId = favoriteForCreateDto.ProductId
			};
			await _favoriteRepository.AddAsync(favorite);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Thêm sản phẩm với ID {favoriteForCreateDto.ProductId} vào danh sách yêu thích của người dùng với ID {favoriteForCreateDto.UserId} thành công.");
		}

		public async Task RemoveFavoriteAsync(int favoriteId)
		{
			var favorite = await _favoriteRepository.FindByCondition(f => f.Id == favoriteId).FirstOrDefaultAsync();
			if (favorite == null)
			{
				_logger.LogError($"Không tìm thấy sản phẩm yêu thích với ID {favoriteId} trong cơ sở dữ liệu.");
				throw new FavoriteNotFoundException($"Không tìm thấy sản phẩm yêu thích với ID {favoriteId} trong cơ sở dữ liệu.");
			}

			_favoriteRepository.Remove(favorite);
			await _favoriteRepository.SaveChangesAsync();
			_logger.LogInformation($"Xóa sản phẩm yêu thích với ID {favoriteId} thành công.");
		}
	}
}