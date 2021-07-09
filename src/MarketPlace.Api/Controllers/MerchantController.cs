using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Api.Controllers
{
    public class MerchantController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MerchantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("v1/merchants")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateMerchantCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return StatusCode(response.Status, response);
        }
    }
}