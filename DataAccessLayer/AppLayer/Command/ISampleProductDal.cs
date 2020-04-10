using CoreLayer.EntityFrameworkRepository;
using EntityLayer.DbLayer.Command;

namespace DataAccessLayer.AppLayer.Command
{
    public interface ISampleProductDal : IEntitiyRepository<SampleProductCommandModel>
    {
    }
}
