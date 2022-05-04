using CryptoDashboard.Datalayer.Coinbase.Configuration;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Services
{
    internal abstract class CoinbaseService
    {
        protected readonly IFlurlClient _flurlClient;

        protected CoinbaseService(
            IFlurlClientFactory clientFactory,
            IConfiguration configuration) 
        {
            _flurlClient = clientFactory.Get(new Flurl.Url(configuration.GetValue<string>(Constants.COINBASE_BASE_URL)));
        }


        protected abstract string Segment();
    }
}
