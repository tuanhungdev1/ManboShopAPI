using ManboShopAPI.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void ApplyGlobalConfigurations(this ModelBuilder modelBuilder)
		{
			GlobalQueryFilterConfiguration.ConfigureGlobalFilters(modelBuilder);
		}
	}
}
