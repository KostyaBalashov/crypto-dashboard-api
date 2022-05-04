using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public class CoinbaseEntityHash : ICoinbaseEntityHash
    {
        public virtual Guid Id { get; set; }

        public virtual string Resource { get; set; } = string.Empty;

        public virtual string ResourcePath { get; set; } = string.Empty;
    }
}
