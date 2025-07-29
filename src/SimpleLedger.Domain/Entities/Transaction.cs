namespace SimpleLedger.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Payee { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public bool IsCredit
        {
            get { return Amount > 0; }
        }
    }
}
