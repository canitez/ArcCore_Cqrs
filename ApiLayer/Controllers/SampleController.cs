using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using BusinessLayer.SampleProduct.Query.Model;
using EntityLayer.DbLayer.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiLayer.Controllers
{
    public class SampleController : BaseController
    {
        private readonly IMediator _mediator;

        public SampleController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(List<GetSampleProduct>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSampleProduct(Guid SampleProductId)
        {
            return Single(await QueryAsync(new GetSampleProduct(SampleProductId)));
        }

   
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateCustomerAsync([FromBody] SampleProductCommandModel command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}