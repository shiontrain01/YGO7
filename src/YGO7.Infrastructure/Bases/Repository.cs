﻿using AirplaneProject.Core.Interfaces;
using AirplaneProject.Domain.Bases;
using AirplaneProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AirplaneProject.Infrastructure.Bases
{
	public class Repository<TEntity> : IRepository<TEntity>
		where TEntity : Entity
	{
		protected readonly AirplaneProjectContext Db;
		protected readonly DbSet<TEntity> DbSet;

		public Repository(AirplaneProjectContext context)
		{
			Db = context;
			DbSet = Db.Set<TEntity>();
		}

		public virtual async Task Add(TEntity obj)
		{
			await DbSet.AddAsync(obj);
		}

		public virtual async Task<TEntity> GetById(int id)
		{
			return await GetById(id, projection: null, includes: null);
		}

		public virtual async Task<TEntity> GetById(int id, params string[] includes)
		{
			return await GetById(id, null, includes);
		}

		public virtual async Task<TEntity> GetById(int id, Expression<Func<TEntity, TEntity>> projection)
		{
			return await GetById(id, projection, includes: null);
		}

		public virtual async Task<TEntity> GetById(int id, Expression<Func<TEntity, TEntity>> projection, params string[] includes)
		{
			var query = GetAll();
			if (projection != null)
			{
				query = query.Select(projection);
			}

			if (includes != null && includes.Length > 0)
			{
				foreach (var include in includes)
				{
					query = query.Include(include);
				}
			}

			query = query.Where(p => p.Id == id);

			return await query.FirstOrDefaultAsync();
		}

		public virtual async Task<TEntity> GetByValue(string value)
		{
			return await GetByValue(value, null);
		}

		public virtual async Task<TEntity> GetByValue(string value, Expression<Func<TEntity, TEntity>> projection)
		{
			var query = GetAll();
			if (projection != null)
			{
				query = query.Select(projection);
			}

			query = query.Where(p => p.Value == value);

			return await query.FirstOrDefaultAsync();
		}

		public virtual async Task<bool> ValueExists(int id, string value)
		{
			var existe = await GetAll()
				.Where(p => p.Id != id
					&& p.Value == value)
				.AnyAsync();

			return existe;
		}

		public virtual async Task<bool> ChildrenExists(int id, Expression<Func<TEntity, bool>> predicate, string include = null)
		{
			var query = GetAll();
			if (!string.IsNullOrEmpty(include))
			{
				query = query.Include(include);
			}

			var existe = await query
				.Where(p => p.Id == id)
				.Where(predicate)
				.AnyAsync();

			return existe;
		}

		public virtual Task<bool> GetAllChildren(int id, Expression<Func<TEntity, bool>> predicate, string include = null)
		{
			var query = GetAll();

			if (!string.IsNullOrEmpty(include))
			{
				query = query.Include(include);
			}

			var allChild = query
				.Where(p => p.Id == id)
				.Where(predicate).AnyAsync();

			return allChild;
		}

		public virtual async Task<bool> IsUnique(Expression<Func<TEntity, bool>> predicate)
		{
			var query = GetAll();

			var existe = await query
				.Where(predicate)
				.AnyAsync();

			return !existe;
		}

		public virtual IQueryable<TEntity> GetAll()
		{
			return DbSet;
		}

		public virtual async Task<IEnumerable<LookupDto>> GetLookup()
		{
			return await DbSet
				.Select(s => new LookupDto { Key = s.Key, ParentKey = s.ParentKey, Value = s.Value })
				.OrderBy(o => o.Value)
				.ToListAsync();
		}

		public virtual IQueryable<TEntity> GetLookupQuery(Expression<Func<TEntity, TEntity>> projection)
		{
			var query = GetAll();
			if (projection != null)
			{
				query = query.Select(projection);
			}

			return query;
		}

		public virtual void Update(TEntity obj)
		{
			DbSet.Update(obj);
		}

		public virtual void Remove(int id)
		{
			DbSet.Remove(DbSet.Find(id));
		}

		public async Task<int> SaveChanges()
		{
			return await Db.SaveChangesAsync();
		}

		public void Dispose()
		{
			Db.Dispose();
			GC.SuppressFinalize(this);
		}

		public virtual IQueryable<TEntity> GetAllAsNoTracking()
		{
			return DbSet.AsNoTracking();
		}

		public IEnumerable<TEntity> GetAllAsNoTracking(Expression<Func<TEntity, TEntity>> projection)
		{
			return DbSet.AsNoTracking().Select(projection);
		}

		public async Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
		{
			return await DbSet.SingleOrDefaultAsync(predicate);
		}

		public async Task<IEnumerable<LookupDto>> GetLookup(Expression<Func<TEntity, bool>> predicate)
		{
			return await DbSet
				.AsNoTracking()
				.Where(predicate)
				.Select(s => new LookupDto { Key = s.Key, ParentKey = s.ParentKey, Value = s.Value })
				.OrderBy(o => o.Value)
				.ToListAsync();
		}
	}
}
