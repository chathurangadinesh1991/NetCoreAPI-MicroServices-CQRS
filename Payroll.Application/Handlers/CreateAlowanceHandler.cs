using MediatR;
using Payroll.Application.Commands;
using Payroll.Domain.Dtos;
using Payroll.Domain.Entities;
using Payroll.Domain.Repositories;

namespace Payroll.Application.Handlers
{
    public class CreateAlowancesHandler : IRequestHandler<CreateAlowancesCommand, bool>
    {
        private readonly IAlowanceRepository _alowanceRepository;

        public CreateAlowancesHandler(IAlowanceRepository alowanceRepository)
        {
            _alowanceRepository = alowanceRepository;
        }

        public async Task<bool> Handle(CreateAlowancesCommand command, CancellationToken cancellationToken)
        {
            var obj = new List<AlowanceDto>();
            obj = command.list;
            return await _alowanceRepository.AddAlowancesAsync(obj);
        }
    }
}
