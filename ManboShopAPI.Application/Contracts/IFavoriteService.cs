using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface IFavoriteService
	{
		Task<IEnumerable<ProductDto>> GetUserFavoriteProductsAsync(int userId);
		Task AddFavoriteAsync(FavoriteForCreateDto favoriteForCreateDto);
		Task RemoveFavoriteAsync(int favoriteId);
	}
}
