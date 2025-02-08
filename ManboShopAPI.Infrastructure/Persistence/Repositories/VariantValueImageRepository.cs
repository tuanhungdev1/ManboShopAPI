using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.Services;


namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class VariantValueImageRepository: RepositoryBase<VariantValueImage>, IVariantValueImageRepository
	{
		private readonly ApplicationDbContext _context;
		public VariantValueImageRepository(ApplicationDbContext dbContext): base(dbContext)
        {
            _context = dbContext;
        }
    }
}
