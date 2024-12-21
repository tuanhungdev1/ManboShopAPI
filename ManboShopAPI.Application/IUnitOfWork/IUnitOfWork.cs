using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		Task BeginTransactionAsync();
		Task CommitAsync();
		Task RollbackAsync();
		Task SaveChangesAsync();
	}
}
