using CryptoDashboard.Api.Models;
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
        private readonly IEnumerable<IHealthCheck> _healthChecks;

        public DashboardController(
            IEnumerable<IWalletsProvider> walletProviders,
            IEnumerable<ITransactionsProvider> transactionsProviders,
            IEnumerable<IHealthCheck> healthChecks)
        {
            _walletProviders = walletProviders;
            _transactionProviders = transactionsProviders;
            _healthChecks = healthChecks;
        }

        [HttpGet("/exchangers")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ExchangerInfo>))]
        public async Task<IEnumerable<ExchangerInfo>> GetExchangersAsync()
        {
            var healthChecking = _walletProviders.GroupJoin(
                _healthChecks,
                wp => wp.Exchanger.Name,
                hc => hc.Exchanger.Name,
                async (provider, healthChckers) =>
                {
                    return new ExchangerInfo()
                    {
                        Exchanger = provider.Exchanger,
                        HealthCheck = healthChckers.Any() ? await healthChckers.Single().HealthCheckAsync() : new HealthCheck()
                        {
                            Description = "Unkown",
                            StatusCode = 0
                        }
                    };
                });

            var results = await Task.WhenAll(healthChecking);

            return results;
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
