using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class EmptyTransactionProvider : ITransactionsProvider
    {
        public Exchanger Exchanger => EmptyExchanger.Exchanger;

        public Task<IEnumerable<Transaction>> GetAllTransactionsAsync(Guid walletId)
        {
            return Task.FromResult(Enumerable.Range(1, 142)
                .Select(i => new EmptyTransaction(
                    Guid.NewGuid(), 
                    new EmptyTransactionStatus(Random.Shared.Next() % 2 == 0 ? "Completed" : "Prepended")))
                .OfType<Transaction>());
        }
    }

    internal class EmptyTransaction : Transaction
    {
        public EmptyTransaction(Guid id, TransactionStatus status) 
            : base(id, status)
        {
        }
    }

    internal class EmptyTransactionStatus : TransactionStatus
    {
        public EmptyTransactionStatus(string description) 
            : base(description)
        {
        }
    }
}
