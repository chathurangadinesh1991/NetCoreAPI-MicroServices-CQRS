using Microsoft.EntityFrameworkCore;
using Payroll.Domain.Dtos;
using Payroll.Domain.Repositories;
using Payroll.Infrastructure.Context;

namespace Payroll.Application.Services
{
    public class AlowanceRepository : IAlowanceRepository
    {
        private readonly PayrollDBContext _dbContext;

        public AlowanceRepository(PayrollDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<AlowanceDto>> GetAlowanceListAsync()
        {
            return await _dbContext.Alowances
                .Select(o => new AlowanceDto
                {
                    EmployeeId = o.Employee.Id,
                    DepartmentId = o.Employee.Department.Id,
                    Date = o.Date,
                    Amount = o.Amount,
                    Status = o.Status.Name
                })
                .ToListAsync();
        }
    }
}
