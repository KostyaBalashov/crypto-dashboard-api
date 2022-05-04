using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public interface IExchanger<TWallet, TTransaction, TWalletDescription>
        where TTransaction : class, ITransaction
        where TWalletDescription : class, IWalletDescription
        where TWallet : class, IWallet<TTransaction, TWalletDescription>
    {
        public IEnumerable<TWallet> Wallets { get; set; }
    }
}
