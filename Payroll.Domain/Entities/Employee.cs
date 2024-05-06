namespace Payroll.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Department Department { get; set; }
    }
}
