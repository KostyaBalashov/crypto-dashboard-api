using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Buys;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using CryptoDashboard.Datalayer.Coinbase.Models;

namespace CryptoDashboard.Datalayer.Coinbase.Providers
{
    internal class TransactionProvider : ITransactionsProvider
    {
        private readonly IBuyService _buyService;

        public Exchanger Exchanger => CoinbaseExchanger.Exchanger;

        public TransactionProvider(IBuyService service)
        {
            _buyService = service;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync(Guid walletId)
        {
            List<CoinbaseTransaction> transactions = new();

            var currentPage = await _buyService.GetNextPageAsync(walletId);
            transactions.AddRange(currentPage.Data.Select(ParseBuy));

            while (!string.IsNullOrWhiteSpace(currentPage.Pagination.NextUri))
            {
                currentPage = await _buyService.GetNextPageAsync(currentPage.Pagination, walletId);
                if (currentPage.Data.Any())
                {
                    transactions.AddRange(currentPage.Data.Select(ParseBuy));
                }
            }

            return transactions;
        }

        private static CoinbaseTransaction ParseBuy(Buy buy)
        {
            return new CoinbaseTransaction(buy.Id, new CoinbaseTransactionStatus(buy.Status.ToString()));
        }
    }
}
