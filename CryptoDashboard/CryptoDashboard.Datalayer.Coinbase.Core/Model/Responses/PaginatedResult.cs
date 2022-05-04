using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Responses
{
    public class PaginatedResult<TEntity> : ApiResponse<ICollection<TEntity>>
        where TEntity : CoinbaseEntity
    {
        public PaginatedResult()
        {
            Data = new List<TEntity>();
        }

        public Pagination Pagination { get; set; } = new Pagination();
    }
}
