using CryptoDashboard.Datalayer.Coinbase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Services
{
    public interface ICoinbaseEntityService<TEntity>
        where TEntity : CoinbaseEntity
    {
        Task<TEntity> GetByIdAsync(Guid id);

        Task<PaginatedResult<TEntity>> GetNextPageAsync(Pagination? currentPage);
    }
}
