using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.EntityFrameworkCore;
using Payroll.Domain.Dtos;
using Payroll.Domain.Entities;
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

        public async Task<bool> AddAlowancesAsync(List<AlowanceDto> alowanceDtos)
        {
            using var transaction = _dbContext.Database.BeginTransaction();

            try
            {
                transaction.CreateSavepoint("startPoint");

                foreach(var item in alowanceDtos)
                {
                    var employee = new Employee { Id = item.EmployeeId };
                    var status = new AlowanceStatus { Name = item.Status };
                    _dbContext.Attach(employee);
                    _dbContext.Attach(status);

                    var alowance = new Alowance
                    {
                        Amount = item.Amount,
                        Employee = employee,
                        Date = item.Date,
                        Status = status
                    };

                    _dbContext.Add(alowance);
                    _dbContext.SaveChanges();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                transaction.RollbackToSavepoint("startPoint");
                throw;
            }            
        }
    }
}
