using Payroll.Domain.Dtos;

namespace Payroll.Domain.Repositories
{
    public interface IAlowanceRepository
    {
        public Task<List<AlowanceDto>> GetAlowanceListAsync();

        public Task<bool> AddAlowancesAsync(List<AlowanceDto> list);
    }
}
