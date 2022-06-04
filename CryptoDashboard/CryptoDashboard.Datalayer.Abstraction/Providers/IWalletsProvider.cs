using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Datalayer.Abstraction.Providers
{
    public interface IWalletsProvider : IExchangerSpecific
    {
        Task<IEnumerable<Wallet>> GetWalletsAsync();
    }
}
