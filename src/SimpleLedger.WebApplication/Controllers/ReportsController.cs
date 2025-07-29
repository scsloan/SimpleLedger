using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Data.Services.Interface;
using SimpleLedger.WebApplication.Models.Reports;

namespace SimpleLedger.WebApplication.Controllers
{
    public class ReportsController : Controller
    {
        private ITransactionService _transactionSrv;
        private ICategoryService _categorySrv;
        public ReportsController(ITransactionService transactionService, ICategoryService categoryService)
        {
            _transactionSrv = transactionService;
            _categorySrv = categoryService;
        }

        public async Task <IActionResult> Index()
        {
            ReportIndexModel model = new ReportIndexModel();
            model.Categories = _categorySrv.GetCategories();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> RunReport(ReportFilterModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid report parameters.");
            }

            model.Results = _transactionSrv.SearchTransactions(model.Category, model.Payee);  

            return PartialView("ReportResults", model);
        }
    }
}
