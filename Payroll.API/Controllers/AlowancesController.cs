using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payroll.Application.Queries;

namespace Payroll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlowancesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlowancesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAlowanceListAsync()
        {
            try
            {
                var list = await _mediator.Send(new GetAlowanceListQuery());
                return Ok(list);
            }
            catch (Exception ex)
            {
                //Log error
                return StatusCode(500);
            }
        }
    }
}