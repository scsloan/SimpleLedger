using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Data.Services.Interface;
using SimpleLedger.WebApplication.Models.Transaction;

namespace SimpleLedger.WebApplication.Controllers
{
    public class TransactionController : Controller
    {
        private ITransactionService _transactionSrv;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionSrv = transactionService;
        }

        public async Task<IActionResult> AddTransaction()
        {

            return PartialView("AddTransactionModal");
        }

        [HttpPost]
        public async Task<IActionResult> Save(AddTransactionModel model)
        {
            _transactionSrv.SaveTransaction(model.ToLedgerTransaction());


            return new JsonResult(new
            {
                success = true,
                message = "Transaction Saved successfully."
            });
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteTransactionModel model)
        {
            _transactionSrv.DeleteTransaction(model.TransactionId);


            return new JsonResult(new
            {
                success = true,
                message = "Transaction deleted successfully."
            });
        }
    }
}
