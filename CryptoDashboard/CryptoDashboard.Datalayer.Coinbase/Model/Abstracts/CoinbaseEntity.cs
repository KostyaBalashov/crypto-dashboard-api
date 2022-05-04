using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts
{
    public abstract class CoinbaseEntity : CoinbaseEntityHash, ICoinbaseHorodatageHash
    {
        [JsonProperty("created_at")]
        public virtual DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public virtual DateTimeOffset UpdatedAt { get; set; }
    }
}
