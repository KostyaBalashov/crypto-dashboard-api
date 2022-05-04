using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Signer
{
    internal interface IApiKeySigner
    {
        string Signe(string epoch, string httpMethod, string requestPath, string secret, string body);
    }
}
