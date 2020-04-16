using System;
using System.Collections.Generic;
using MediatR;

namespace Application.SampleProduct.Query.Model
{
    public class GetSampleProduct : IRequest<List<GetSampleProduct>>
    {

        public Guid SampleProductId { get; }

        public GetSampleProduct(Guid productId)
        {
            SampleProductId = productId;
        }
    }
}
