using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.Models.Home
{
    public class DashboardModel
    {
        public decimal Balance { get;  set; }
        public List<LedgerTransaction> LastCredits { get;  set; }
        public List<LedgerTransaction> LastDebits { get; set; }


        public DashboardModel()
        {
            LastCredits = new List<LedgerTransaction>();
            LastDebits = new List<LedgerTransaction>();
        }
    }
}
