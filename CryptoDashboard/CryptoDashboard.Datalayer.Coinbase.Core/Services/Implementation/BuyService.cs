using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Buys;
using CryptoDashboard.Datalayer.Coinbase.Core.Services.Abstracts;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Implementation
{
    internal class BuyService : CoinbaseChildEntityService<Buy>, IBuyService
    {
        public BuyService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
            : base(clientFactory, configuration, apiConfiguration)
        {
        }

        protected override string ParentSegment() =>
            Constants.ACCOUNTS_SEGMENT;

        protected override string Segment() =>
            Constants.BUYS_SEGMENT;
    }
}
