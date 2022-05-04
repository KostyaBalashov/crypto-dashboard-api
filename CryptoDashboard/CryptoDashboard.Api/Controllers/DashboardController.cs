using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;
using Microsoft.AspNetCore.Mvc;

namespace CryptoDashboard.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IEnumerable<IWalletsProvider> _walletProviders;
        private readonly IEnumerable<ITransactionsProvider> _transactionProviders;

        public DashboardController(IEnumerable<IWalletsProvider> walletProviders, IEnumerable<ITransactionsProvider> transactionsProviders)
        {
            _walletProviders = walletProviders;
            _transactionProviders = transactionsProviders;
        }

        [HttpGet("/exchangers")]
        public IEnumerable<Exchanger> GetExchangers()
        {
            return _walletProviders.Select(provider => provider.Exchanger);
        }

        [HttpGet("/wallets")]
        public Task<IEnumerable<Wallet>> GetWallets(string exchangerName)
        {
            return _walletProviders
                .Single(provider => provider.Exchanger.Name == exchangerName)
                .GetWalletsAsync();
        }

        [HttpGet("/transactions")]
        public Task<IEnumerable<Transaction>> GetTransactions(string exchangerName, Guid walletId)
        {
            return _transactionProviders
                .Single(provider => provider.Exchanger.Name == exchangerName)
                .GetAllTransactionsAsync(walletId);
        }
    }
}
