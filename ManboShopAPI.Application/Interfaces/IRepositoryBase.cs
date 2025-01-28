using System.Linq.Expressions;

namespace ManboShopAPI.Domain.Interfaces
{
	public interface IRepositoryBase<T> where T : class
	{
		Task<T> GetOrCreateAsync(
			Expression<Func<T, bool>> predicate,
			Func<T> createNew);
		Task<T?> GetByIdAsync(int id, bool asNoTracking = false);
		Task<IEnumerable<T>> GetAllAsync(bool asNoTracking);
		Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, bool asNoTracking = false);
		IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool asNoTracking = false);
		IQueryable<T> FindAll(bool asNoTracking = false);
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);
		void Update(T entity);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);
		Task SaveChangesAsync();
	}
}
