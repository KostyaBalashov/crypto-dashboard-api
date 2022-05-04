using CryptoDashboard.Datalayer.Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Models
{
    internal class CoinbaseExchanger : Exchanger
    {
        public CoinbaseExchanger(string name, string description) 
            : base(name, description)
        {
        }

        public static CoinbaseExchanger Exchanger => new("Coinbase", "Coinbase Exchanger");
    }
}
