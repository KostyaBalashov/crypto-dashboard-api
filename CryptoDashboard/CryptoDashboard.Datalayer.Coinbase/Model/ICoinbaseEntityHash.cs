using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public interface ICoinbaseEntityHash
    {
        Guid Id { get; set; }

        string Resource { get; set; }

        string ResourcePath { get; set; }
    }
}
