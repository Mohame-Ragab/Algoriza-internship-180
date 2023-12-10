using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeeta.Application.interfaces;
using Vezeeta.Context;

namespace Vezeeta.Application.services
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VezeetaContext context;

        public Repository(VezeetaContext context)
        {
            this.context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
           var newEntity = await context.Set<T>().AddAsync(entity);
            return (newEntity).Entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity is null)
            {
                return false;
            }
            else
            {
                 context.Set<T>().Remove(entity);
                return true;
            }
        }

        public   Task<IQueryable<T>> GetAllAsync()
        {
            var AllEntities =  context.Set<T>().AsQueryable();
            return Task.FromResult(AllEntities);

        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync( T entity)
        {
            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllPaginateFiltered(int page = 1, int pageSize = 5, Expression<Func<T, bool>> filterExpression = null)
        {
            var query = await GetAllAsync();

            if (filterExpression is not null)
            {
                query = query.Where(filterExpression);
            }

            return await query.Skip(pageSize * (page -1)).Take(pageSize).ToListAsync();
        }
    }
}
