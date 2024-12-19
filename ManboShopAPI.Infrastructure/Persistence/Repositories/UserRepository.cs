using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public async Task<bool> EmailExistsAsync(string email)
		{
			return await _dbSet.AnyAsync(u => u.Email == email);
		}
	}
}
