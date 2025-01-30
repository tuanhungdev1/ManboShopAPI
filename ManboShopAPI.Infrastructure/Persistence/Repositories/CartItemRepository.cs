using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class CartItemRepository : RepositoryBase<CartItem>, ICartItemRepository
	{
		public CartItemRepository(ApplicationDbContext context) : base(context)
		{
		}


		
	}
}
