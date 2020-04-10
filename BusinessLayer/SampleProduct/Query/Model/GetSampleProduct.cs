using System;
using System.Collections.Generic;
using MediatR;

namespace BusinessLayer.SampleProduct.Query.Model
{
    public class GetSampleProduct : IRequest<List<GetSampleProduct>>
    {

        public Guid SampleProductId { get; }

        public GetSampleProduct(Guid productId)
        {
            this.SampleProductId = productId;
        }
    }
}
