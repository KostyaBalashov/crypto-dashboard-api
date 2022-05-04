using CryptoDashboard.Datalayer.Coinbase.Configuration;
using CryptoDashboard.Datalayer.Coinbase.Model;
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
    internal abstract class CoinbaseEntityService<TEntity> : CoinbaseService, ICoinbaseEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        protected readonly IApiConfiguration _apiConfiguration;

        protected CoinbaseEntityService(IFlurlClientFactory clientFactory, IConfiguration configuration, IApiConfiguration apiConfiguration)
            : base(clientFactory, configuration)
        {
            _apiConfiguration = apiConfiguration;
        }

        public virtual Task<TEntity> GetByIdAsync(Guid id)
        {
            _apiConfiguration.Configure(_flurlClient);
            return _flurlClient.Request(Segment(), id).GetJsonAsync<TEntity>();
        }

        public virtual Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage)
        {
            _apiConfiguration.Configure(_flurlClient);
            IFlurlRequest request;
            if (currentPage != null)
            {
                request = _flurlClient.Request(currentPage.NextUri);
            }
            else
            {
                request = _flurlClient.Request(Segment());
            }

            return request.GetJsonAsync<PaginatedResult<TEntity>>();
        }
    }
}
