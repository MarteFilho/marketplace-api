using System.Threading;
using System.Threading.Tasks;
using MarketPlace.Application.Commands;
using MarketPlace.Application.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Api.Controllers
{
    public class EstablishmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public EstablishmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("v1/establishments")]
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] GetAllEstablishmentRequest query, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(query, cancellationToken);
            return StatusCode(response.Status, response);
        }

        [Route("v1/establishments")]
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateEstablishmentCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return StatusCode(response.Status, response);
        }

        [Route("v1/establishments/category")]
        [HttpPost]
        public async Task<ActionResult> CreateEstablishmentCategory([FromBody] CreateEstablishmentCategoryCommand command, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return StatusCode(response.Status, response);
        }
    }
}