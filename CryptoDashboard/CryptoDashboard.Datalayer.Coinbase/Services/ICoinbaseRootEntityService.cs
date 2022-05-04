using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services
{
    public interface ICoinbaseRootEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        Task<ApiResponse<TEntity>> GetByIdAsync(Guid id);

        Task<PaginatedResult<TEntity>> GetNextPageAsync();

        Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage);
    }
}
