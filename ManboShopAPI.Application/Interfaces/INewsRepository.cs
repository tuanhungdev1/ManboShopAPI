using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.Interfaces
{
	public interface INewsRepository : IRepositoryBase<News>
	{
		Task<PagedList<News>> FetchAllNewsWithPaging(NewsRequestParameters newsRequestParameters);
		Task<IEnumerable<News>> GetNewsWithDetailsAsync(bool asNoTracking = false);
		Task<News?> GetNewsByIdWithDetailsAsync(int id, bool asNoTracking = false);
		Task<bool> ExistsAsync(int id);
		Task<bool> TitleExistsAsync(string title);
	}
}
