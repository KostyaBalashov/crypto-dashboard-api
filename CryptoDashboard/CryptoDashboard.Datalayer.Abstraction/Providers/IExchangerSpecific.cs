using CryptoDashboard.Datalayer.Abstraction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Abstraction.Providers
{
    public interface IExchangerSpecific
    {
        Exchanger Exchanger { get; }
    }
}
