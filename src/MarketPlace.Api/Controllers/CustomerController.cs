using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Api.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("v1/customers")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateCustomerCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return StatusCode(response.Status, response);
        }

        [Route("v1/customers/auth")]
        [HttpPost]
        public async Task<ActionResult> Auth([FromBody] LoginCustomerCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return StatusCode(response.Status, response);
        }
    }
}