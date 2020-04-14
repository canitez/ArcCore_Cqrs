using Core.EntityFrameworkRepository;
using DataAccess.AppLayer.Command;
using DataAccess.DbEntity.Orm.EntityFramework.CommandContext;
using Entity.DbLayer.Command;

namespace DataAccess.DbEntity.Command
{
    public class SampleProductDal : EntityRepositoryBase<SampleProductCommandModel, EfQueryContext>, ISampleProductDal
    {
    }
}
