using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class EmptyTransactionProvider : ITransactionsProvider
    {
        public Exchanger Exchanger => EmptyExchanger.Exchanger;

        public Task<IEnumerable<Transaction>> GetAllTransactionsAsync(Guid walletId)
        {
            return Task.FromResult(Enumerable.Empty<Transaction>());
        }
    }
}
