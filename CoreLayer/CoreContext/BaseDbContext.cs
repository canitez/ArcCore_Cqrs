using Microsoft.EntityFrameworkCore;

namespace CoreLayer.CoreContext
{
    public abstract class BaseDbContext<T> : DbContext, IEfCoreDbContext where T : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
