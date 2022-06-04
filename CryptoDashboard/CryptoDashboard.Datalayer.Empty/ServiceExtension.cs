using CryptoDashboard.Datalayer.Abstraction.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoDashboard.Datalayer.Empty
{
    public static class ServiceExtension
    {
        public static void AddEmptyWalletProvider(this IServiceCollection service)
        {
            service.AddScoped<ITransactionsProvider, EmptyTransactionProvider>();
            service.AddScoped<IWalletsProvider, EmptyWalletProvider>();
            service.AddScoped<IHealthCheck, HealthCheck>();
        }
    }
}
