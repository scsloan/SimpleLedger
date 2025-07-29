using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.Models.Home
{
    public class LedgerViewModel
    {
        public  List<LedgerTransaction> Transactions { get; set; }

        public decimal TotalBalance
        {
            get { return Transactions.Sum(t => t.Amount); }
        }
        public LedgerViewModel()
        {
            Transactions = new List<LedgerTransaction>();
        }
    }
}
