using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFavoriteRepository : IRepositoryBase<Favorite>
	{
		Task<IEnumerable<Product>> GetProductsByUserIdAsync(int userId, bool asNoTracking = false);
	}
}
