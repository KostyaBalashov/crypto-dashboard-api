using Flurl.Http;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Configuration
{
    internal interface IApiConfiguration
    {
        void Configure(IFlurlClient client);
    }
}
