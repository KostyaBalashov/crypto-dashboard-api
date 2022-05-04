using CryptoDashboard.Datalayer.Abstraction.Model;

namespace CryptoDashboard.Datalayer.Coinbase.Models
{
    internal class CoinbaseWallet : Wallet
    {
        public CoinbaseWallet(string name, Guid id, decimal balance, string currency, DateTimeOffset createdAt) 
            : base(name, id, balance, currency, createdAt)
        {
        }
    }
}
