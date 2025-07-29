namespace SimpleLedger.Domain.Entities
{
    public class Ledger
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Transaction> Transactions { get; set; }

        public decimal Balance
        {
            get { return Transactions.Sum(t => t.Amount); }
        }

        public Ledger() 
        { 
            Transactions = new List<Transaction>();
        }
    }
}
