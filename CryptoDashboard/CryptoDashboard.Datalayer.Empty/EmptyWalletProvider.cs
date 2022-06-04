using CryptoDashboard.Datalayer.Abstraction.Model;
using CryptoDashboard.Datalayer.Abstraction.Providers;

namespace CryptoDashboard.Datalayer.Empty
{
    internal class EmptyWalletProvider : IWalletsProvider
    {
        public Exchanger Exchanger => EmptyExchanger.Exchanger;

        public Task<IEnumerable<Wallet>> GetWalletsAsync()
        {
            return Task.FromResult(Enumerable.Range(1, 15)
                .Select(i => new EmptyWallet(
                    $"Empty - {1}",
                    Guid.NewGuid(),
                    Random.Shared.Next(),
                    $"Currecny - {i}",
                    DateTimeOffset.Now))
                .OfType<Wallet>());
        }
    }

    internal class EmptyWallet : Wallet
    {
        public EmptyWallet(string name, Guid id, decimal balance, string currency, DateTimeOffset createdAt) 
            : base(name, id, balance, currency, createdAt)
        {
        }
    }
}
