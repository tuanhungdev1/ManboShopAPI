using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using System.Security.Claims;

namespace ManboShopAPI.Application.Contracts
{
	public interface IFavoriteService
	{
		Task<IEnumerable<ProductDto>> GetUserFavoriteProductsAsync(int userId);
		Task AddFavoriteAsync(FavoriteForCreateDto favoriteForCreateDto);
		Task RemoveFavoriteAsync(int favoriteId);
		Task<int> GetCountFavoriteForCurrentUser(ClaimsPrincipal user);
	}
}
