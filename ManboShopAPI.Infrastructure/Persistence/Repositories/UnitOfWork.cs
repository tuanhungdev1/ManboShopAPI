using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Application.UnitOfWork;
using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly ApplicationDbContext _context;
        private IDbContextTransaction? _transaction;
        private bool _disposed;

        private readonly Lazy<INewsDetailRepository> _newsDetailRepository;
        private readonly Lazy<INewsRepository> _newsRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IBrandRepository> _brandRepository;
		private readonly Lazy<IBannerRepository> _bannerRepository;
        private readonly Lazy<ICartItemRepository> _cartItemRepository;
        private readonly Lazy<ICartRepository> _cartRepository;
        private readonly Lazy<IOrderDetailRepository> _orderDetailRepository;
        private readonly Lazy<IAttributeRepository> _attributeRepository;
        private readonly Lazy<OrderRepository> _orderRepository;
        private readonly Lazy<IProductAttributeValueRepository> _productAttributeValueRepository;
        private readonly Lazy<IProductVariantValueRepository> _productVariantValueRepository;
        private readonly Lazy<IFavoriteRepository> _favoriteRepository;
        private readonly Lazy<IBannerDetailRepository> _bannerDetailRepository;
		public UnitOfWork(ApplicationDbContext context,
                          UserManager<User> userManager
        )
        {
            _context = context;
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_context));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_context));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
            _brandRepository = new Lazy<IBrandRepository>(() => new BrandRepository(_context));
            _newsDetailRepository = new Lazy<INewsDetailRepository>(() => new NewsDetailRepository(_context));
            _newsRepository = new Lazy<INewsRepository>(() => new NewsRepository(_context));
            _bannerRepository = new Lazy<IBannerRepository>(() => new BannerRepository(_context));
            _cartItemRepository = new Lazy<ICartItemRepository>(() => new CartItemRepository(_context));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(_context));
            _orderDetailRepository = new Lazy<IOrderDetailRepository>(() => new OrderDetailRepository(_context));
            _orderRepository = new Lazy<OrderRepository>(() => new OrderRepository(_context));
            _attributeRepository = new Lazy<IAttributeRepository>(() => new AttributeRepository(_context));
            _productAttributeValueRepository = new Lazy<IProductAttributeValueRepository>(() => new ProductAttributeValueRepository(_context));
            _productVariantValueRepository = new Lazy<IProductVariantValueRepository>(() => new ProductVariantValueRepository(_context));
            _favoriteRepository = new Lazy<IFavoriteRepository>(() => new FavoriteRepository(_context));
            _bannerDetailRepository = new Lazy<IBannerDetailRepository>(() => new BannerDetailRepository(_context));
        }

        public IBrandRepository BrandRepository => _brandRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;
        public INewsRepository NewsRepository => _newsRepository.Value;
        public INewsDetailRepository NewsDetailRepository => _newsDetailRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public ICategoryRepository CategoryRepository => _categoryRepository.Value;
        public IBannerRepository BannerRepository => _bannerRepository.Value;
        public ICartItemRepository CartItemRepository => _cartItemRepository.Value;
        public ICartRepository CartRepository => _cartRepository.Value;
        public IOrderDetailRepository OrderDetailRepository => _orderDetailRepository.Value;
        public IOrderRepository OrderRepository => _orderRepository.Value;
        public IAttributeRepository AttributeRepository => _attributeRepository.Value;
        public IProductAttributeValueRepository ProductAttributeValueRepository => _productAttributeValueRepository.Value;

        public IProductVariantValueRepository ProductVariantValueRepository => _productVariantValueRepository.Value;
        public IFavoriteRepository FavoriteRepository => _favoriteRepository.Value;
        public IBannerDetailRepository BannerDetailRepository => _bannerDetailRepository.Value;
        public async Task BeginTransactionAsync()
        {
            if (_transaction != null)
            {
                throw new InvalidOperationException("A transaction is already in progress.");
            }

            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await SaveChangesAsync();
                await _transaction?.CommitAsync();
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task RollbackAsync()
        {
            try
            {
                await _transaction?.RollbackAsync();
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Log the exception details
                throw new Exception("An error occurred while saving changes to the database.", ex);
            }
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();
            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (!_disposed)
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                }

                await _context.DisposeAsync();
                _disposed = true;
            }
        }
    }
}
