using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts
{
    public abstract class CoinbaseEntityHash : ICoinbaseEntityHash
    {
        public virtual Guid Id { get; set; }

        public virtual string Resource { get; set; } = string.Empty;

        [JsonProperty("resource_path")]
        public virtual string ResourcePath { get; set; } = string.Empty;
    }
}
