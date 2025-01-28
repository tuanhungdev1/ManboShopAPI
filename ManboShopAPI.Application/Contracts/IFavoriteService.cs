using ManboShopAPI.Application.DTOs.FavoriteDtos;
using ManboShopAPI.Application.DTOs.ProductDtos;
using System.Security.Claims;

namespace ManboShopAPI.Application.Contracts
{
	public interface IFavoriteService
	{
		Task<IEnumerable<ProductDto>> GetUserFavoriteProductsAsync(ClaimsPrincipal user);
		Task AddFavoriteAsync(ClaimsPrincipal user, FavoriteForCreateDto favoriteForCreateDto);
		Task RemoveFavoriteAsync(ClaimsPrincipal user, FavoriteForCreateDto favoriteForCreateDto);
		Task<int> GetCountFavoriteForCurrentUser(ClaimsPrincipal user);
	}
}
