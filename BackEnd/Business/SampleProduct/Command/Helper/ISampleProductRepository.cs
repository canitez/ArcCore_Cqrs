using Core.EntityFrameworkRepository;
using Entity.DbLayer.Command;

namespace Application.SampleProduct.Command.Helper
{
    public interface ISampleProductRepository
    {
        void Add(SampleProductCommandModel sampleProductCommand);
    }
}
