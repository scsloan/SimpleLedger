using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.Models.Transaction
{
    public class AddTransactionModel
    {
        public string Payee { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }



        public LedgerTransaction ToLedgerTransaction()
        {
            return new LedgerTransaction
            {
                Payee = Payee,
                Category = Category,
                Date = Date,
                Amount = Amount
            };
        }   

    }
}
