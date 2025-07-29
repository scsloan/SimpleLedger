using SimpleLedger.Domain.Entities;
using SimpleLedger.Domain.Enums;

namespace SimpleLedger.Data.Services.Interface
{
    public interface ITransactionService
    {
        void DeleteTransaction(int id);
        decimal GetCurrrentBalance();
        List<LedgerTransaction> GetLastTransactions(TransactionType typeOfTransaction, int takeNum);
        List<LedgerTransaction> GetTransactions();
        int SaveTransaction(LedgerTransaction transaction);
        List<LedgerTransaction> SearchTransactions(string category, string payee);
    }
}