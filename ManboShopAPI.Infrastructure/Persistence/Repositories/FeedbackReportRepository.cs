using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Application.Interfaces;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class FeedbackReportRepository : RepositoryBase<FeedbackReport>, IFeedbackReportRepository
	{
        public FeedbackReportRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
