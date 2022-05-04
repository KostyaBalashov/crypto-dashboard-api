using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Services;
using CryptoDashboard.Datalayer.Coinbase.Core.Services.Implementation;
using CryptoDashboard.Datalayer.Coinbase.Core.Signer;
using Flurl.Http.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CryptoDashboard.Datalayer.Coinbase.Core
{
    public static class ServicesExtension
    {
        public static void AddCoinbaseServices(this IServiceCollection service)
        {
            service.AddSingleton<IFlurlClientFactory, PerBaseUrlFlurlClientFactory>();
            service.AddSingleton<ITimeService, TimeService>();
            service.AddSingleton<IApiKeySigner, CoinbaseApiKeySigner>();

            service.AddSingleton<IApiConfiguration, ApiKeyConfiguration>();

            service.AddScoped<IAccountService, AccountService>();
            service.AddScoped<IBuyService, BuyService>();
        }
    }
}
