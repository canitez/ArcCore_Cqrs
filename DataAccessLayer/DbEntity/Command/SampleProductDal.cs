using CoreLayer.EntityFrameworkRepository;
using DataAccessLayer.AppLayer.Command;
using DataAccessLayer.DbEntity.Orm.EntityFramework;
using EntityLayer.DbLayer.Command;

namespace DataAccessLayer.DbEntity.Command
{
    public class SampleProductDal : EntityRepositoryBase<SampleProductCommandModel, EfContext>, ISampleProductDal
    {
    }
}
