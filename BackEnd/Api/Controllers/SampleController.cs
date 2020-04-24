using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Application.SampleProduct.Query.Model;
using Entity.DbLayer.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : BaseController
    {
        private readonly IMediator _mediator;

        public SampleController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<GetSampleProduct>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetSampleProduct(Guid sampleProductId)
        {
            return Single(await QueryAsync(new GetSampleProduct(sampleProductId)));
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateSampleProductAsync([FromBody] SampleProductCommandModel command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}