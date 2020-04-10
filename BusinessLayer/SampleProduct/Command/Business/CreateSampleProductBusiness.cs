using BusinessLayer.SampleProduct.Command.Helper;
using CoreLayer.CoreCommand;
using EntityLayer.DbLayer.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.SampleProduct.Command.Business
{
    public class CreateSampleProductBusiness : ICommandRouter<SampleProductCommandModel, Guid>
    {

        private readonly ISampleProductRepository sampleProductRepository;


        public CreateSampleProductBusiness(ISampleProductRepository samplePRoductRepository)
        {
            this.sampleProductRepository = samplePRoductRepository ?? throw new ArgumentNullException(nameof(sampleProductRepository));
        }

        public async Task<bool> Handle(SampleProductCommandModel request, CancellationToken cancellationToken)
        {
            await sampleProductRepository.Add(request);
            return true;
        }

        Task<Guid> IRequestHandler<SampleProductCommandModel, Guid>.Handle(SampleProductCommandModel request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}