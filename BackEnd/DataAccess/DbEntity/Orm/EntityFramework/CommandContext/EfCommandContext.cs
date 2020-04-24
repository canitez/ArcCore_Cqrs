using Core.CoreContext;
using Entity.DbLayer.Command;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DbEntity.Orm.EntityFramework.CommandContext
{
    public class EfQueryContext : BaseDbContext<EfQueryContext>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("");//sql server conf
        }

        DbSet<SampleProductCommandModel> SampleProducts { get; set; }
    }
}
