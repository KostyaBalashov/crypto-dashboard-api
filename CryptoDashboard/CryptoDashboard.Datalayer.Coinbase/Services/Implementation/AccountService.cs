using CryptoDashboard.Datalayer.Coinbase.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Model;
using CryptoDashboard.Datalayer.Coinbase.Model.Accounts;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Services.Implementation
{
    internal class AccountService : CoinbaseEntityService<Account>, IAccountService
    {
        public AccountService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
            : base(clientFactory, configuration, apiConfiguration)
        {
        }

        protected override string Segment() =>
            Constants.ACCOUNTS_SEGMENT;
    }
}
