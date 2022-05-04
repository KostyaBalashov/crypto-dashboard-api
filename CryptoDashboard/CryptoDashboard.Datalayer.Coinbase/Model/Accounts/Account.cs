using CryptoDashboard.Datalayer.Coinbase.Core.Model.Abstracts;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CryptoDashboard.Datalayer.Coinbase.Core.Model.Accounts
{
    public class Account : CoinbaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public bool Primary { get; set; }

        public MoneyValue Balance { get; set; } = new MoneyValue(0, string.Empty);

        public AccountType Type { get; set; }
    }
}
