using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IProductImageRepository : IRepositoryBase<ProductImage>
	{
		Task<IEnumerable<ProductImage>> GetProductImagesByProductIdAsync(int productId, bool asNoTracking = false);
		Task<bool> IsProductImageExistAsync(int productId, string imageUrl);
	}
}
