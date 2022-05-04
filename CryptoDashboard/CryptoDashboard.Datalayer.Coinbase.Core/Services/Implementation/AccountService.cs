using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Accounts;
using CryptoDashboard.Datalayer.Coinbase.Core.Services.Abstracts;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Implementation
{
    internal class AccountService : CoinbaseRootEntityService<Account>, IAccountService
    {
        public AccountService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
            : base(clientFactory, configuration, apiConfiguration)
        {
        }

        protected override string Segment() =>
            Constants.ACCOUNTS_SEGMENT;
    }
}
