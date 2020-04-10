using System.Threading.Tasks;
using CoreLayer.CoreContext;
using Microsoft.EntityFrameworkCore;

namespace CoreLayer.EntityFrameworkRepository
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : BaseDbContext<TContext>, new()
    {
        public async Task Add(TEntity entity)
        {
            //Disposable pattern
            using (var context = new TContext())
            {
                var add = context.Entry(entity);
                add.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var delete = context.Entry(entity);
                delete.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var update = context.Entry(entity);
                update.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

    }
}
