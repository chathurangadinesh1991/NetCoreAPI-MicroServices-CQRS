using Payroll.Application.Handlers;
using Payroll.Application.Queries;
using Payroll.Domain.Repositories;
using PayrollUnitTest.Mocks;

namespace PayrollUnitTest.Tests
{
    public class AlowanceTest
    {
        private IAlowanceRepository _repository;
        private GetAlowanceListHandler _handler;

        public AlowanceTest()
        {
            _repository = AlowanceMock.GetAlowanceRepository();
            _handler = new GetAlowanceListHandler(_repository);
        }

        [Fact]
        public async Task GetAlowanceListAsync()
        {
            //Assign
            var request = new GetAlowanceListQuery();
            var token = new CancellationToken();
            //Act
            var result = await _handler.Handle(request, token);
            // Assert
            Assert.NotNull(result);
        }
    }
}
