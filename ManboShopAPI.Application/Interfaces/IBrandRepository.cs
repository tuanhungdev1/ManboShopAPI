using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IBrandRepository : IRepositoryBase<Brand>
	{
		Task<Brand?> GetBrandWithProductsAsync(int brandId);
		Task<bool> BrandExistsAsync(string brandName);
		Task<bool> BrandExistsByIdAsync(int brandId);
		Task<PagedList<Brand>> FetchAllCategoriesWithPaging(BrandRequestParameters brandRequestParameters);
	}
}
