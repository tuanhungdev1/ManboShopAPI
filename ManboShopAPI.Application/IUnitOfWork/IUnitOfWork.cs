using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Interfaces;

namespace ManboShopAPI.Application.UnitOfWork
{
	public interface IUnitOfWork : IAsyncDisposable
	{
		public IUserRepository UserRepository { get; }
        public INewsRepository NewsRepository { get; }
        public INewsDetailRepository NewsDetailRepository { get; }
        public IProductRepository ProductRepository { get; }
		public ICategoryRepository CategoryRepository { get; }
		public IBrandRepository BrandRepository { get; }
		public IBannerRepository BannerRepository { get; }
		public ICartItemRepository CartItemRepository { get; }
		public ICartRepository CartRepository { get; }
		public IOrderRepository OrderRepository { get; }
		public IOrderDetailRepository OrderDetailRepository { get; }
		public IAttributeRepository AttributeRepository { get; }
		public IProductAttributeValueRepository ProductAttributeValueRepository { get; }
        public IProductVariantValueRepository ProductVariantValueRepository { get; }
        public IFavoriteRepository FavoriteRepository { get; }
        public IBannerDetailRepository BannerDetailRepository { get; }
		public IAddressRepository AddressRepository { get; }
		public IFeedbackRepository FeedbackRepository { get; }
		public IFeedbackLikeRepository FeedbackLikeRepository { get; }
		public IFeedbackReportRepository FeedbackReportRepository { get; }
        Task BeginTransactionAsync();
		Task CommitAsync();
		Task RollbackAsync();
		Task SaveChangesAsync();
	}
}
