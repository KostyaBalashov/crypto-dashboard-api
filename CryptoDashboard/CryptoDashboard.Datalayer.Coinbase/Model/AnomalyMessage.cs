using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public class AnomalyMessage
    {
        public string Id { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;
    }
}
