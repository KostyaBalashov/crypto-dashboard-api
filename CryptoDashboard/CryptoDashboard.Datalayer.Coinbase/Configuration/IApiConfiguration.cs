using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Configuration
{
    internal interface IApiConfiguration
    {
        void Configure(IFlurlClient client);
    }
}
