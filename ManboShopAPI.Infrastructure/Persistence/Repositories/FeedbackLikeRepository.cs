using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class FeedbackLikeRepository : RepositoryBase<FeedbackLike>, IFeedbackLikeRepository
	{
		public FeedbackLikeRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
