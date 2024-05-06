using Moq;
using Payroll.Domain.Dtos;
using Payroll.Domain.Entities;
using Payroll.Domain.Repositories;

namespace PayrollUnitTest.Mocks
{
    public class AlowanceMock
    {
        static Random rand = new Random();       

        public static List<AlowanceDto> alowances = new List<AlowanceDto>()
        {
            new AlowanceDto()
            {
                EmployeeId = rand.Next(),
                DepartmentId = rand.Next(),
                Date = DateTime.Now,
                Amount = (float)rand.NextDouble(),
                Status = "Pending"
            },
            new AlowanceDto()
            {
                EmployeeId = rand.Next(),
                DepartmentId = rand.Next(),
                Date = DateTime.Now,
                Amount = (float)rand.NextDouble(),
                Status = "Completed"
            }
        };

        public static IAlowanceRepository GetAlowanceRepository()
        {
            var moq = new Mock<IAlowanceRepository>();
            moq.Setup(x => x.GetAlowanceListAsync()).Returns(Task.FromResult(alowances));
            return moq.Object;
        }
    }
}
