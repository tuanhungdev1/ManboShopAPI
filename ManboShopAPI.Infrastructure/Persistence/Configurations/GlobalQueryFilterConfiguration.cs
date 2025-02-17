

using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ManboShopAPI.Infrastructure.Persistence.Configurations
{
	public static class GlobalQueryFilterConfiguration
	{
		public static void ConfigureGlobalFilters(ModelBuilder modelBuilder)
		{
			ConfigureSoftDeleteFilter(modelBuilder);
			ConfigureEntitySpecificFilters(modelBuilder);
		}

		private static void ConfigureSoftDeleteFilter(ModelBuilder modelBuilder)
		{
			foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			{
				if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
				{
					var parameter = Expression.Parameter(entityType.ClrType, "e");
					var property = Expression.Property(parameter, "IsDeleted");
					var falseConstant = Expression.Constant(false);
					var expression = Expression.Equal(property, falseConstant);
					var lambda = Expression.Lambda(expression, parameter);

					modelBuilder.Entity(entityType.ClrType)
						.HasQueryFilter(lambda);
				}
			}
		}

		private static void ConfigureEntitySpecificFilters(ModelBuilder modelBuilder)
		{
			// Các filter đặc biệt cho từng entity có thể thêm ở đây
			modelBuilder.Entity<Order>().HasQueryFilter(order => !order.IsDeleted);
			// Ví dụ: modelBuilder.Entity<Product>().HasQueryFilter(product => !product.IsDeleted && product.IsActive);
		}
	}
}
