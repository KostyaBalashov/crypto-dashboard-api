using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoDashboard.Datalayer.Coinbase.Model
{
    public class Pagination
    {
        public Guid EndingBefore { get; set; }

        public Guid StartingAfter { get; set; }

        public int Limit { get; set; }

        public SortingOrder Order { get; set; }

        public string PreviousUri { get; set; } = string.Empty;

        public string NextUri { get; set; } = string.Empty;
    }
}
