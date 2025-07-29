using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.Models.Reports
{
    public class ReportFilterModel
    {
        public string Category { get; set; }
        public string Payee { get; set; }
        public List<LedgerTransaction> Results { get;  set; }

        public ReportFilterModel()
        {
            Results = new List<LedgerTransaction>();
        }
    }
}
