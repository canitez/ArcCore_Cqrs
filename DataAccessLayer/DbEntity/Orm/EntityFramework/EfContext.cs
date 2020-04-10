using CoreLayer.CoreContext;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.DbEntity.Orm.EntityFramework
{
    public class EfContext : BaseDbContext<EfContext>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("");
        }
        //TO DO Cqrs içinde dbset araştır

        //public DbSet<Sample> Samples { get; set; }
    }
}
