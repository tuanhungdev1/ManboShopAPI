using ManboShopAPI.Domain.Entities;
using ManboShopAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Interfaces
{
	public interface IUserRepository : IRepositoryBase<User>
	{
		Task<User?> GetUserByEmailAsync(string email, bool asNoTracking = false);
		Task<User?> GetUserWithOrdersAsync(int userId, bool asNoTracking = false);
		Task<bool> EmailExistsAsync(string email);
	}
}
