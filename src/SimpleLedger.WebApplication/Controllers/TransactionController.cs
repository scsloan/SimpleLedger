using Microsoft.AspNetCore.Mvc;
using SimpleLedger.Data.Services.Interface;
using SimpleLedger.WebApplication.Models.Transaction;

namespace SimpleLedger.WebApplication.Controllers
{
    public class TransactionController
    {
        private ITransactionService _transactionSrv;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionSrv = transactionService;
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
