using Microsoft.EntityFrameworkCore;
using Payroll.Domain.Entities;

namespace Payroll.Infrastructure.Context
{
    public class PayrollDBContext : DbContext
    {
        public PayrollDBContext(DbContextOptions<PayrollDBContext> options) : base(options)
        {

        }

        public DbSet<Alowance> Alowances { get; set; }
        public DbSet<AlowanceStatus> AlowanceStatuses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
