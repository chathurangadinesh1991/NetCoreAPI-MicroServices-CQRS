namespace Payroll.Domain.Dtos
{
    public class AlowanceDto
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public string Status { get; set; }
    }
}
