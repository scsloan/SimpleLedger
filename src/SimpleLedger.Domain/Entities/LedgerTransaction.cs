using SimpleLedger.Domain.Enums;

namespace SimpleLedger.Domain.Entities
{
    public class LedgerTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Payee { get; set; }
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public TransactionType TypeOfTransaction 
        {
            get
            {
                if (Amount > 0)
                {
                     return TransactionType.Credit;
                }

                return TransactionType.Debit;
            }
        }
    }
}
