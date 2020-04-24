using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.EntityFrameworkRepository
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<IList<T>> GetList(Expression<Func<T, bool>> filter = null);
    }
}
