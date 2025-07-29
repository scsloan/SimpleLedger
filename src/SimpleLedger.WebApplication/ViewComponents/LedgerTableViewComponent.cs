using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Domain.Entities;
using SimpleLedger.WebApplication.Models.ViewComponents.LedgerTable;

namespace SimpleLedger.WebApplication.ViewComponents
{
    public class LedgerTableViewComponent : ViewComponent
    {
        public LedgerTableViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync(List<LedgerTransaction> transactions, bool showButtons = false)
        {
            LedgerTableModel model = new LedgerTableModel();
            model.Transactions = transactions;
            model.ShowButtons = showButtons;
            return View(model);
        }
    }
}
