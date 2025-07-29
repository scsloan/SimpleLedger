using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Domain.Entities;

namespace SimpleLedger.WebApplication.ViewComponents
{
    public class LedgerByCategoryViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(List<LedgerTransaction> transactions)
        {
            List<string> categoryList = transactions
                .Select(t => t.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();  

            List<KeyValuePair<string,decimal>> model = new List<KeyValuePair<string, decimal>>();

            foreach (var category in categoryList)
            {
                decimal amt = transactions
                    .Where(t => t.Category == category)
                    .Sum(t => t.Amount);

                model.Add(new KeyValuePair<string, decimal>(category, amt));
            }

            return View(model);
        }

    }
}
