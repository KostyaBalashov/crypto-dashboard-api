using CryptoDashboard.Datalayer.Coinbase.Core.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;
using Flurl.Http;
using Flurl.Http.Configuration;
using Microsoft.Extensions.Configuration;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services.Abstracts
{
    internal abstract class CoinbaseChildEntityService<TEntity> : CoinbaseService<TEntity>, ICoinbaseChildEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        protected CoinbaseChildEntityService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
            : base(clientFactory, configuration, apiConfiguration)
        {   
        }


        public virtual Task<ApiResponse<TEntity>> GetByIdAsync(Guid parentId, Guid id) =>
            _flurlClient
                .Request(ParentSegment(), parentId, Segment(), id)
                .GetJsonAsync<ApiResponse<TEntity>>();

        public Task<PaginatedResult<TEntity>> GetNextPageAsync(Guid parentId) =>
            GetNextPageAsync(null, parentId);

        public Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage, Guid parentId) =>
            RequestPaginatedResult(currentPage?.NextUri ?? $"{ParentSegment()}/{parentId}/{Segment()}");

        protected abstract string ParentSegment();

        protected abstract string Segment();
    }
}
