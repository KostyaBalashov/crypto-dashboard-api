using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public abstract class CoinbaseEntity : CoinbaseEntityHash, ICoinbaseHorodatageHash
    {
        public virtual DateTimeOffset CreatedAt { get; set; }

        public virtual DateTimeOffset UpdatedAt { get; set; }
    }
}
