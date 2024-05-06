namespace Payroll.Domain.Entities
{
    public class Alowance
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public virtual AlowanceStatus Status { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
