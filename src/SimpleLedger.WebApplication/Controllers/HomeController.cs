using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Data.Services.Interface;
using SimpleLedger.Domain.Enums;
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
            DashboardModel model = new DashboardModel();
            model.Balance = _transactionSrv.GetCurrrentBalance();

            model.LastDebits = _transactionSrv.GetLastTransactions(TransactionType.Debit, 5);
            model.LastCredits = _transactionSrv.GetLastTransactions(TransactionType.Credit, 5);

            return View(model);
        }

        public async Task<IActionResult> Ledger()
        {
            LedgerViewModel model = new LedgerViewModel();
            model.Transactions = _transactionSrv.GetTransactions();

            return View(model);
        }
    }
}
