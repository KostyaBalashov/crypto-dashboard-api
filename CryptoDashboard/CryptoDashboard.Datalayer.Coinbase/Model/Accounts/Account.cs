using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model.Accounts
{
    public class Account : CoinbaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public bool Primary { get; set; }

        public string Currency { get; set; } = string.Empty;

        public MoneyValue Balance { get; set; } = new MoneyValue(0, string.Empty);

        public AccountType Type { get; set; }
    }
}
