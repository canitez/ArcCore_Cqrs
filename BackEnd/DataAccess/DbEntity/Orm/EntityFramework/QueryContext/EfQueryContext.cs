using Core.CoreContext;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbEntity.Orm.EntityFramework.QueryContext
{
    public class EfQueryContext : BaseDbContext<EfQueryContext>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");//sql server conf
        }
    }
}
