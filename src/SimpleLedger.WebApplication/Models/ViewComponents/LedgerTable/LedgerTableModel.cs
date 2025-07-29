using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.Models.ViewComponents.LedgerTable
{
    public class LedgerTableModel
    {
        public List<LedgerTransaction> Transactions { get; set; } = new List<LedgerTransaction>();
        public bool ShowButtons { get; set; } = false;
    }
}
