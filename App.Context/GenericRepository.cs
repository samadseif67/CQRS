using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Context
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<TEntity> GetAsync(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter);
        int SaveChange();
        Task<int> SaveChangeAsync();

    }
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppContext context;
        public GenericRepository(AppContext context)
        {
            this.context = context;
        }


        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var Find = await GetAsync(id);
            context.Set<TEntity>().Remove(Find);
            return true;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            var Result = await context.Set<TEntity>().FindAsync(id);
            return Result;
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsQueryable();
        }

        public TEntity Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            return entity;
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().Where(filter);
        }

        public int SaveChange()
        {
           return context.SaveChanges();
        }

        public async Task<int> SaveChangeAsync()
        {
           return await context.SaveChangesAsync();
        }

       
    }
}
