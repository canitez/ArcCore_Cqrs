using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.CoreContext;
using Microsoft.EntityFrameworkCore;

namespace Core.EntityFrameworkRepository
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
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

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<IList<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? await context.Set<TEntity>().ToListAsync() :
                   await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

    }
}
