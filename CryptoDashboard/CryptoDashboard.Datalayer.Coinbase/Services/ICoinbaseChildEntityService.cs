using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Services
{
    public interface ICoinbaseChildEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        Task<ApiResponse<TEntity>> GetByIdAsync(Guid parentId, Guid id);

        Task<PaginatedResult<TEntity>> GetNextPageAsync(Guid parentId);

        Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage, Guid parentId);
    }
}
