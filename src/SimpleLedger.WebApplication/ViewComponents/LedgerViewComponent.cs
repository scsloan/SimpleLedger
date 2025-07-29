using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.ViewComponents
{
    public class LedgerViewComponent : ViewComponent
    {
        public LedgerViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(List<Transaction> transactions)
        {
            Ledger model = new Ledger();
            model.Transactions = transactions;
            return View(model);
        }
    }
}
