﻿using ManboShopAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Infrastructure.Persistence.Repositories
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected readonly ApplicationDbContext _context;
		protected readonly DbSet<T> _dbSet;

		protected RepositoryBase(ApplicationDbContext context)
		{
			_context = context;
			_dbSet = context.Set<T>();
		}

		//AsNoTracking (ON) : True
		//AsNoTracking (OFF) : False

		public async Task<IEnumerable<T>> GetAllAsync(bool asNoTracking = false)
		{
			return !asNoTracking
				? await _dbSet.ToListAsync()
				: await _dbSet.AsNoTracking().ToListAsync();
		}

		public async Task<T?> GetByIdAsync(int id, bool asNoTracking = false)
		{
			if (asNoTracking)
			{
				return await _dbSet.AsNoTracking().FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
			}
			return await _dbSet.FindAsync(id);
		}


		public IQueryable<T> FindAll(bool asNoTracking = false) =>
			!asNoTracking ?
			_context.Set<T>().AsNoTracking() :
			_context.Set<T>();

		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool asNoTracking = false) =>
			!asNoTracking ?
			_context.Set<T>().Where(expression).AsNoTracking() :
			_context.Set<T>().Where(expression);

		public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate, bool asNoTracking = false)
		{
			return !asNoTracking
				? await _dbSet.Where(predicate).ToListAsync()
				: await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<T> entities)
		{
			await _dbSet.AddRangeAsync(entities);
		}

		public void Update(T entity)
		{
			_dbSet.Update(entity);

		}

		public void Remove(T entity)
		{
			_dbSet.Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_dbSet.RemoveRange(entities);
		}

		public async Task SaveChangesAsync()
		{
			await _context.SaveChangesAsync();
		}


	}
}
