using SimpleLedger.Domain.Entities;

namespace SimpleLedger.Data.Services.Interface
{
    public interface ITransactionService
    {
        void DeleteTransaction(int id);
        List<Transaction> GetTransactions();
        int SaveTransaction(Transaction transaction);
    }
}