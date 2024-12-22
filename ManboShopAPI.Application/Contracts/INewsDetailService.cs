using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.NewsDetailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface INewsDetailService
	{
		Task<(IEnumerable<NewsDetailDto> newsDetailDtos, MetaData metaData)> GetAllNewsDetailAsync(NewsDetailRequestParameters newsDetailRequestParameters);
		Task<NewsDetailDto> GetNewsDetail(int id);
		Task<IEnumerable<NewsDetailDto>> GetByNewsIdAsync(int newsId);
		Task<IEnumerable<NewsDetailDto>> GetByProductIdAsync(int productId);
		Task<bool> ExistsAsync(int newsId, int productId);
		Task CreateNewsDetailAsync(NewsDetailForCreateDto newsDetailForCreateDto);
		Task UpdateNewsDetailAsync(int id, NewsDetailForUpdateDto newsDetailForUpdateDto);
		Task DeleteNewsDetailAsync(int id);
		Task AddNewsDetailsAsync(int newsId, IEnumerable<int> productIds);
		Task RemoveNewsDetailsAsync(int newsId);
	}
}
