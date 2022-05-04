using CryptoDashboard.Datalayer.Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Models
{
    public class CoinbaseTransactionStatus : TransactionStatus
    {
        public CoinbaseTransactionStatus(string description) 
            : base(description)
        {
        }
    }
}
