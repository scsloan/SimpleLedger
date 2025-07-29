using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Data.Services.Interface;
using SimpleLedger.WebApplication.Models.Home;

namespace SimpleLedger.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransactionService _transactionSrv;   
        public HomeController(ILogger<HomeController> logger, ITransactionService transService)
        {
            _logger = logger;
            _transactionSrv = transService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Ledger()
        {
            LedgerViewModel model = new LedgerViewModel();
            model.Transactions = _transactionSrv.GetTransactions();

            return View(model);
        }
    }
}
