using ManboShopAPI.Application.Interfaces;
using ManboShopAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public class VariantRepository : RepositoryBase<Variant>, IVariantRepository
	{
		public VariantRepository(ApplicationDbContext context) : base(context)
		{
		}

		public async Task<Variant?> GetVariantWithValuesAsync(int id)
		{
			return await _dbSet
				.Include(v => v.VariantValues)
				.FirstOrDefaultAsync(v => v.Id == id);
		}

		public async Task<IEnumerable<Variant>> GetAllVariantsWithValuesAsync()
		{
			return await _dbSet
				.Include(v => v.VariantValues)
				.ToListAsync();
		}

		public async Task<bool> IsNameExistAsync(string name)
		{
			return await _dbSet
				.AnyAsync(v => v.Name.ToLower() == name.ToLower());
		}

		public async Task<bool> IsNameExistAsync(string name, int excludeId)
		{
			return await _dbSet
				.AnyAsync(v => v.Name.ToLower() == name.ToLower() && v.Id != excludeId);
		}

		// Thêm phương thức tìm kiếm Variant theo tên
		public async Task<IEnumerable<Variant>> SearchByNameAsync(string searchTerm)
		{
			return await _dbSet
				.Where(v => v.Name.Contains(searchTerm))
				.Include(v => v.VariantValues)
				.ToListAsync();
		}

		// Phương thức kiểm tra xem Variant có đang được sử dụng không
		public async Task<bool> IsVariantInUseAsync(int id)
		{
			return await _dbSet
				.Include(v => v.VariantValues)
				.AnyAsync(v => v.Id == id && v.VariantValues.Any());
		}

		// Phương thức lấy Variant với phân trang
		public async Task<(IEnumerable<Variant> Variants, int TotalCount)> GetPagedVariantsAsync(
			int pageNumber,
			int pageSize,
			string? searchTerm = null)
		{
			var query = _dbSet.AsQueryable();

			if (!string.IsNullOrWhiteSpace(searchTerm))
			{
				query = query.Where(v => v.Name.Contains(searchTerm));
			}

			var totalCount = await query.CountAsync();

			var variants = await query
				.Include(v => v.VariantValues)
				.Skip((pageNumber - 1) * pageSize)
				.Take(pageSize)
				.ToListAsync();

			return (variants, totalCount);
		}

		public ICollection<Variant> GetVariantsWithValuesByValueIds(IEnumerable<int> variantValueIds)
		{
			return _context.Variants
				.Include(v => v.VariantValues)
				.ThenInclude(vv => vv.VariantValueImages)
				.Where(v => v.VariantValues.Any(vv => variantValueIds.Contains(vv.Id)))
				.ToList();
		}
	}
}

