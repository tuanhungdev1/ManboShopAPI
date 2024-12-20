using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IFavoriteRepository : IRepositoryBase<Favorite>
	{
		Task<IEnumerable<Product>> GetProductsByUserIdAsync(int userId, bool asNoTracking = false);
	}
}
