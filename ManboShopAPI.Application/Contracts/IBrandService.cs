using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.BrandDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface IBrandService
	{
		Task<(IEnumerable<BrandDto> categories, MetaData metaData)> GetAllBrandAsync(BrandRequestParameters brandRequestParameters);
		Task<BrandDto> GetBrandByIdAsync(int brandId);
		Task CreateBrandAsync(BrandForCreateDto brandForCreateDto);
		Task UpdateBrandAsync(int brandId, BrandForUpdateDto brandForUpdateDto);
		Task DeleteBrandAsync(int brandId);
		Task<bool> BrandExistsAsync(string brandName);
		Task<BrandDto> GetBrandByNameAsync(string brandName);
	}
}
