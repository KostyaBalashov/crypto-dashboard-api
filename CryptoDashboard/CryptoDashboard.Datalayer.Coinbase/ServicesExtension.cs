using CryptoDashboard.Datalayer.Coinbase.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Services;
using CryptoDashboard.Datalayer.Coinbase.Services.Implementation;
using CryptoDashboard.Datalayer.Coinbase.Signer;
using Flurl.Http.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase
{
    public static class ServicesExtension
    {
        public static void AddCoinbaseProvider(this IServiceCollection service)
        {
            service.AddSingleton<IFlurlClientFactory, PerBaseUrlFlurlClientFactory>();
            service.AddSingleton<ITimeService, TimeService>();
            service.AddSingleton<IApiKeySigner, CoinbaseApiKeySigner>();

            service.AddSingleton<IApiConfiguration, ApiKeyConfiguration>();

            service.AddScoped<IAccountService, AccountService>();
        }
    }
}
