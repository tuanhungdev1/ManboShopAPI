using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IBrandRepository : IRepositoryBase<Brand>
	{
		Task<Brand?> GetBrandWithProductsAsync(int brandId);
		Task<bool> BrandExistsAsync(string brandName);
		Task<PagedList<Brand>> FetchAllCategoriesWithPaging(BrandRequestParameters brandRequestParameters);
	}
}
