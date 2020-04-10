using System.Threading.Tasks;

namespace CoreLayer.EntityFrameworkRepository
{
    public interface IEntitiyRepository<T> where T : class, IEntity, new()
    {
        Task Add(T entity);
        Task Update(T entity);
        Task  Delete(T entity);
    }
}
