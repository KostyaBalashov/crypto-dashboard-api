using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Accounts;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using CryptoDashboard.Datalayer.Coinbase.Models;

namespace CryptoDashboard.Datalayer.Coinbase.Providers
{
    internal class WalletProvider : IWalletsProvider
    {
        private readonly IAccountService _accountService;

        public WalletProvider(IAccountService service)
        {
            _accountService = service;
        }

        public Exchanger Exchanger => CoinbaseExchanger.Exchanger;

        public async Task<IEnumerable<Wallet>> GetWalletsAsync()
        {
            List<CoinbaseWallet> wallets = new();

            var currentPage = await _accountService.GetNextPageAsync();
            wallets.AddRange(currentPage.Data.Select(ParseAccount));

            while (!string.IsNullOrEmpty(currentPage.Pagination.NextUri))
            {
                currentPage = await _accountService.GetNextPageAsync(currentPage.Pagination);
                if (currentPage.Data.Any())
                {
                    wallets.AddRange(currentPage.Data.Select(ParseAccount));
                }
            }

            return wallets;
        }

        private static CoinbaseWallet ParseAccount(Account account)
        {
            return new CoinbaseWallet(account.Name, account.Id, account.Balance.Amount, account.Balance.Currency, account.CreatedAt);
        }
    }
}
