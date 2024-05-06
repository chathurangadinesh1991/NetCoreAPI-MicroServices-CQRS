using MediatR;
using Microsoft.AspNetCore.Mvc;
using Payroll.Application.Commands;
using Payroll.Application.Queries;
using Payroll.Domain.Dtos;
using Payroll.Domain.Models;

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

        [HttpPost]
        public async Task<IActionResult> PostFile([FromForm] FileUploadModel file)
        {
            if (file == null)
            {
                return BadRequest();
            }

            try
            {
                List<AlowanceDto> list = new List<AlowanceDto>();
                //Read data from CSV insert into List
                //list.Add(new AlowanceDto
                //{
                //    EmployeeId = 3,
                //    Amount = 12,
                //    Date = DateTime.Now,
                //    Status = string.Empty,
                //    DepartmentId = 2
                //});

                await _mediator.Send(new CreateAlowancesCommand(list));
                return Ok();
            }
            catch (Exception ex)
            {
                //Log error
                return StatusCode(500);
            }
        }
    }
}