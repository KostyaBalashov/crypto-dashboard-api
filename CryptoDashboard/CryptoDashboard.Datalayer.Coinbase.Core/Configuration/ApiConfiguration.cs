using Flurl.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Configuration
{
    internal abstract class ApiConfiguration : IApiConfiguration
    {
        protected ApiConfiguration(IConfiguration configuration)
        {
            BaseUrl = configuration.GetValue<string>(Constants.COINBASE_BASE_URL);
            ApiVersion = configuration.GetValue<string>(Constants.COINBASE_API_VERSION);
        }

        public virtual string BaseUrl { get; set; }

        public virtual string ApiVersion { get; set; }

        public abstract void Configure(IFlurlClient client);
    }
}
