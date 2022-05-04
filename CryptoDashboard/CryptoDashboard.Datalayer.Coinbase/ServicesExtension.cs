using CryptoDashboard.Datalayer.Abstraction.Providers;
using CryptoDashboard.Datalayer.Coinbase.Core;
using CryptoDashboard.Datalayer.Coinbase.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoDashboard.Datalayer.Coinbase
{
    public static class ServicesExtension
    {
        public static void AddCoinbaseProviders(this IServiceCollection service)
        {
            service.AddCoinbaseServices();

            service.AddScoped<IWalletsProvider, WalletProvider>();

            service.AddScoped<ITransactionsProvider, TransactionProvider>();
        }
    }
}
