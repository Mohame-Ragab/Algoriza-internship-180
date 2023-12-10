using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Application.interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<bool> DeleteAsync(int id);
         Task UpdateAsync(T entity);

        Task<IEnumerable<T>> GetAllPaginateFiltered(int page =1, int pageSize = 5, Expression<Func<T,bool>> filterExpression = null);
    }
}
