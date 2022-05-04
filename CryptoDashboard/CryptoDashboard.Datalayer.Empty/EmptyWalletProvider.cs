using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class EmptyWalletProvider : IWalletsProvider
    {
        public Exchanger Exchanger => EmptyExchanger.Exchanger;

        public Task<IEnumerable<Wallet>> GetWalletsAsync()
        {
            return Task.FromResult(Enumerable.Empty<Wallet>());
        }
    }
}
