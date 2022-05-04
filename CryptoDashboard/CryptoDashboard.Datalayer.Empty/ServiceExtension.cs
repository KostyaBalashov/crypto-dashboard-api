using CryptoDashboard.Datalayer.Abstraction.Providers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Empty
{
    public static class ServiceExtension
    {
        public static void AddEmptyWalletProvider(this IServiceCollection service)
        {
            service.AddScoped<ITransactionsProvider, EmptyTransactionProvider>();
            service.AddScoped<IWalletsProvider, EmptyWalletProvider>();
        }
    }
}
