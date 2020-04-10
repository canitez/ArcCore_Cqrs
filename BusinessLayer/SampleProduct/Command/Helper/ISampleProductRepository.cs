using CoreLayer.EntityFrameworkRepository;
using EntityLayer.DbLayer.Command;

namespace BusinessLayer.SampleProduct.Command.Helper
{
    public interface ISampleProductRepository : IEntitiyRepository<SampleProductCommandModel>
    {
       
    }
}
