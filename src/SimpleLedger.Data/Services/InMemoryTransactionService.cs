using SimpleLedger.Data.Services.Interface;
using SimpleLedger.Domain.Entities;
using SimpleLedger.Domain.Enums;
using System.Reflection;

namespace SimpleLedger.Data.Services
{
    public class InMemoryTransactionService : ITransactionService, ICategoryService
    {
        private static List<LedgerTransaction> _transactions;

        public InMemoryTransactionService()
        {
            init();
        }

        private void init()
        {
            if (_transactions == null)
            {
                _transactions = new List<LedgerTransaction>
                {
                    new LedgerTransaction { Id = 1, Date = DateTime.Now.AddDays(-10), Payee = "Alice", Amount = 100, Category = "Pet Care"},
                    new LedgerTransaction { Id = 2, Date = DateTime.Now.AddDays(-5), Payee = "Bob", Amount = -50, Category = "Auto Service" },
                    new LedgerTransaction { Id = 3, Date = DateTime.Now.AddDays(-2), Payee = "Charlie", Amount = 200, Category= "Entertainment" }
                };
            }
        }

        public List<LedgerTransaction> GetTransactions()
        {
            return _transactions;
        }

        public int SaveTransaction(LedgerTransaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction));

            if (transaction.Id == 0)
            {
                transaction.Id = _transactions.Max(t => t.Id) + 1;
                _transactions.Add(transaction);
            }
            else
            {
                var existingTransaction = _transactions.FirstOrDefault(t => t.Id == transaction.Id);
                if (existingTransaction != null)
                {
                    existingTransaction.Date = transaction.Date;
                    existingTransaction.Payee = transaction.Payee;
                    existingTransaction.Amount = transaction.Amount;
                }
            }
            return transaction.Id;
        }

        public void DeleteTransaction(int id)
        {
            var transaction = _transactions.FirstOrDefault(t => t.Id == id);

            if (transaction != null)
            {
                _transactions.Remove(transaction);
            }
        }

        public List<string> GetCategories()
        {
            return _transactions.Select(x => x.Category).Distinct().ToList();
        }

        public List<LedgerTransaction> SearchTransactions(string category, string payee)
        {
                return _transactions.Where(t => (string.IsNullOrEmpty(category) || t.Category == category) &&
                                                (string.IsNullOrEmpty(payee) || t.Payee == payee))
                                    .ToList();  
        }

        public decimal GetCurrrentBalance()
        {
            return _transactions.Sum(t => t.Amount);
        }

        public List<LedgerTransaction> GetLastTransactions(TransactionType TypeOfTransaction, int TakeAmt)
        {
            return _transactions.Where(t => t.TypeOfTransaction == TypeOfTransaction).OrderByDescending(t => t.Date).Take(TakeAmt).ToList();
        }
    }
}
