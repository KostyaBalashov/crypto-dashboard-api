using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Model
{
    public interface IWallet<TTransaction, TWalletDescription> 
        where TTransaction : class, ITransaction
        where TWalletDescription : class, IWalletDescription
    {
        IEnumerable<TTransaction> Transactions { get; set; }

        TWalletDescription Description { get; set; }
    }
}
