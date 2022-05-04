using CryptoDashboard.Datalayer.Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Provider
{
    public interface ICryptoDataProvider<TExchanger, TTransaction, TWalletDescription, TWallet>
        where TTransaction: class, ITransaction
        where TWalletDescription : class, IWalletDescription
        where TWallet : class, IWallet<TTransaction, TWalletDescription>
        where TExchanger : class, IExchanger<TWallet, TTransaction, TWalletDescription>
    {
    }
}
