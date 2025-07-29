using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.ViewComponents
{
    public class LedgerByPayeeViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(List<LedgerTransaction> transactions)
        {
            List<string> payeeList = transactions
                .Select(t => t.Payee)
                .Distinct()
                .OrderBy(c => c)
                .ToList();  

            List<KeyValuePair<string,decimal>> model = new List<KeyValuePair<string, decimal>>();

            foreach (var payee in payeeList)
            {
                decimal amt = transactions
                    .Where(t => t.Payee == payee)
                    .Sum(t => t.Amount);

                model.Add(new KeyValuePair<string, decimal>(payee, amt));
            }

            return View(model);
        }

    }
}
