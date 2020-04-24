using Core.CoreCommand;
using DataAccess.AppLayer.Command;
using Entity.DbLayer.Command;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.SampleProduct.Command.Handler
{
    public class CreateSampleProductBusiness : ICommandRouter<SampleProductCommandModel,Unit>
    {
        private readonly ISampleProductDal _sampleProductDal;

        public CreateSampleProductBusiness(ISampleProductDal sampleProductDal)
        {
            _sampleProductDal = sampleProductDal;
            sampleProductDal = sampleProductDal ?? throw new ArgumentNullException(nameof(sampleProductDal));
        }

        public async Task<Unit> Handle(SampleProductCommandModel request, CancellationToken cancellationToken)
        {
            await _sampleProductDal.Add(request);
            return await Task.FromResult(Unit.Value);
        }

    }
}