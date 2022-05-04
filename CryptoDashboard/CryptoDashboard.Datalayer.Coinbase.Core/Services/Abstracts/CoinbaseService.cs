using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Abstracts
{
    internal abstract class CoinbaseService<TEntity>
        where TEntity : CoinbaseEntity
    {
        protected readonly IFlurlClient _flurlClient;
        protected readonly IApiConfiguration _apiConfiguration;

        public CoinbaseService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
        {
            _flurlClient = clientFactory.Get(new Flurl.Url(configuration.GetValue<string>(Constants.COINBASE_BASE_URL)));
            _apiConfiguration = apiConfiguration;

            _apiConfiguration.Configure(_flurlClient);
        }

        protected virtual async Task<PaginatedResult<TEntity>> RequestPaginatedResult(string urlSegment) =>
            await _flurlClient.Request(urlSegment).GetJsonAsync<PaginatedResult<TEntity>>();
    }
}
