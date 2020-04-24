using Core.EntityFrameworkRepository;
using Entity.DbLayer.Command;

namespace DataAccess.AppLayer.Command
{
    public interface ISampleProductDal : IEntityRepository<SampleProductCommandModel>
    {
    }
}
