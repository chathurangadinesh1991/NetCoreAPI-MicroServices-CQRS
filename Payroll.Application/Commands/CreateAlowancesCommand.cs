using MediatR;
using Payroll.Domain.Dtos;

namespace Payroll.Application.Commands
{
    public class CreateAlowancesCommand : IRequest<bool>
    {
        public List<AlowanceDto> list = new List<AlowanceDto>();

        public CreateAlowancesCommand(List<AlowanceDto> _list)
        {
            list = _list;
        }
    }
}
