using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.DTOs.NewsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Contracts
{
	public interface INewsService
	{
		Task<(IEnumerable<NewsDto> news, MetaData metaData)> GetAllNewsAsync(NewsRequestParameters newsRequestParameters);
		Task<NewsDto> GetNewsByIdAsync(int newsId);
		Task CreateNewsAsync(NewsForCreateDto newsForCreateDto);
		Task UpdateNewsAsync(int newsId, NewsForUpdateDto newsForUpdateDto);
		Task DeleteNewsAsync(int newsId);
		Task<NewsDto> GetNewsByTitleAsync(string title);
	}
}
