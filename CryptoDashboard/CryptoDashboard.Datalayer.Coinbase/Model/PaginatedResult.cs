using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public class PaginatedResult<TEntity> 
        where TEntity : CoinbaseEntity
    {
        public Pagination Pagination { get; set; } = new Pagination();

        public IEnumerable<TEntity> Entities { get; set; } = Enumerable.Empty<TEntity>();
    }
}
