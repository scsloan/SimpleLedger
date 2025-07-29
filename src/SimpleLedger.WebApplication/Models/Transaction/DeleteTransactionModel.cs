namespace SimpleLedger.WebApplication.Models.Transaction
{
    public class DeleteTransactionModel
    {
        public int TransactionId { get; set; }
        public DeleteTransactionModel()
        {
            TransactionId = 0;
        }
        public DeleteTransactionModel(int transactionId)
        {
            TransactionId = transactionId;
        }
    }
}
