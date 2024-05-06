using MediatR;
using Payroll.Application.Queries;
using Payroll.Domain.Dtos;
using Payroll.Domain.Repositories;

namespace Payroll.Application.Handlers
{
    public class GetAlowanceListHandler : IRequestHandler<GetAlowanceListQuery, List<AlowanceDto>>
    {
        private readonly IAlowanceRepository _alowanceRepository;

        public GetAlowanceListHandler(IAlowanceRepository alowanceRepository)
        {
            _alowanceRepository = alowanceRepository;
        }

        public async Task<List<AlowanceDto>> Handle(GetAlowanceListQuery query, CancellationToken cancellationToken)
        {
            return await _alowanceRepository.GetAlowanceListAsync();
        }
    }
}
