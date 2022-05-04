using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Datalayer.Abstraction.Providers
{
    public interface ITransactionsProvider : IExchangerSpecific
    {
        Task<IEnumerable<Transaction>> GetAllTransactionsAsync(Guid walletId);
    }
}
