using ManboShopAPI.Application.Common.Request;
using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class UserRepository : RepositoryBase<User>, IUserRepository
	{
		public UserRepository(ApplicationDbContext context) : base(context) { }

		public async Task<User?> GetUserByEmailAsync(string email, bool asNoTracking = false)
		{
			var query = _dbSet.Where(u => u.Email == email);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public async Task<PagedList<User>> FetchAllUserAsync(UserRequestParameters userRequestParameters)
		{
			var query = _dbSet.AsNoTracking().AsQueryable();

			if(!string.IsNullOrWhiteSpace(userRequestParameters.SearchTerm))
			{
				query = query.Where(u => u.UserName!.Contains(userRequestParameters.SearchTerm) 
									|| u.Email!.Contains(userRequestParameters.SearchTerm)
									|| u.FirstName.Contains(userRequestParameters.SearchTerm)
									|| u.LastName.Contains(userRequestParameters.SearchTerm)
									);
			}

			if(!string.IsNullOrWhiteSpace(userRequestParameters.OrderKey))
			{
				var orderKey = userRequestParameters.OrderKey.Trim().ToLower();
				var orderBy = !string.IsNullOrWhiteSpace(userRequestParameters.OrderBy) && userRequestParameters.OrderBy.Trim().ToLower() == "desc";

				query = orderKey switch
				{
					"username" => orderBy ? query.OrderByDescending(u => u.UserName) : query.OrderBy(u => u.UserName),
					"email" => orderBy ? query.OrderByDescending(u => u.Email) : query.OrderBy(u => u.Email),
					"firstname" => orderBy ? query.OrderByDescending(u => u.FirstName) : query.OrderBy(u => u.FirstName),
					"lastname" => orderBy ? query.OrderByDescending(u => u.LastName) : query.OrderBy(u => u.LastName),
					"address" => orderBy ? query.OrderByDescending(u => u.Address) : query.OrderBy(u => u.Address),
					_ => orderBy ? query.OrderByDescending(u => u.UserName) : query.OrderBy(u => u.UserName)
				};
			} else if(!string.IsNullOrWhiteSpace(userRequestParameters.OrderBy))
			{
				var orderBy = userRequestParameters.OrderBy.Trim().ToLower() == "desc";
				query = orderBy ? query.OrderByDescending(u => u.UserName) : query.OrderBy(u => u.UserName);
			}
			else
			{
				query = query.OrderBy(u => u.UserName);
			}


			var totalCount = await query.CountAsync();

			var items = await query
				.Skip((userRequestParameters.PageNumber - 1) * userRequestParameters.PageSize)
				.Take(userRequestParameters.PageSize)
				.ToListAsync();

			return new PagedList<User>(items, totalCount, userRequestParameters.PageNumber, userRequestParameters.PageSize);
		}


		public async Task<User?> GetUserWithOrdersAsync(int userId, bool asNoTracking = false)
		{
			var query = _dbSet
				.Include(u => u.Orders)
				.Include(u => u.Addresses)
				.Where(u => u.Id == userId);

			return asNoTracking
				? await query.AsNoTracking().FirstOrDefaultAsync()
				: await query.FirstOrDefaultAsync();
		}

		public Task<bool> UserExistsAsync(int userId)
		{
			return _dbSet.AnyAsync(u => u.Id == userId);
		}

		public async Task<bool> EmailExistsAsync(string email)
		{
			return await _dbSet.AnyAsync(u => u.Email == email);
		}

		public async Task<bool> UserNameExistsAsync(string userName)
		{
			return await _dbSet.AnyAsync(u => u.UserName == userName);
		}
	}
}
