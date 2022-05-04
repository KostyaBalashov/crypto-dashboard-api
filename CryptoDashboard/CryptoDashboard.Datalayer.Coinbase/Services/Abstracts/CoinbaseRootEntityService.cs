using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Abstracts
{
    internal abstract class CoinbaseRootEntityService<TEntity> : CoinbaseService<TEntity>, ICoinbaseRootEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        protected CoinbaseRootEntityService(IFlurlClientFactory clientFactory,IConfiguration configuration, IApiConfiguration apiConfiguration) 
            : base(clientFactory, configuration, apiConfiguration)
        {
        }


        protected abstract string Segment();

        public Task<PaginatedResult<TEntity>> GetNextPageAsync() =>
            GetNextPageAsync(null);

        public Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage) =>
            RequestPaginatedResult(currentPage?.NextUri ?? Segment());

        public virtual Task<ApiResponse<TEntity>> GetByIdAsync(Guid id) =>
            _flurlClient
                .Request(Segment(), id)
                .GetJsonAsync<ApiResponse<TEntity>>();
    }
}
