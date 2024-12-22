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
	public interface INewsDetailRepository : IRepositoryBase<NewsDetail>
	{
		Task<PagedList<NewsDetail>> FetchAllNewsDetailsAsync(NewsDetailRequestParameters newsDetailRequestParameters);
		Task<IEnumerable<NewsDetail>> GetByNewsIdAsync(int newsId, bool asNoTracking = false);
		Task<bool> ExistsAsync(int newsId, int productId);
		Task<IEnumerable<NewsDetail>> GetByProductIdAsync(int productId, bool asNoTracking = false);
		Task AddNewsDetailsAsync(int newsId, IEnumerable<int> productIds);
		Task RemoveNewsDetailsAsync(int newsId);
	}
}
