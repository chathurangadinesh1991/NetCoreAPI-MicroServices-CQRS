using MediatR;
using Payroll.Domain.Dtos;

namespace Payroll.Application.Queries
{
    public class GetAlowanceListQuery : IRequest<List<AlowanceDto>>
    {

    }
}
